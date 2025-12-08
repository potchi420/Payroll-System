using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class EmployeePayslips : Form
    {
        public EmployeePayslips()
        {
            InitializeComponent();
            greetUser(Connector.SessionData.EmployeeID ?? 0);
            loadPayslips(Connector.SessionData.EmployeeID ?? 0);
            SetupGridColumns();
            LoadMonthFilter(month_filter);
            LoadYearFilter(year_fiter);
            payslipGrid.CellFormatting += PayslipGrid_CellFormatting;
            payslipGrid.CellMouseMove += payslipGrid_CellMouseMove;
            payslipGrid.DataBindingComplete += payslipGrid_DataBindingComplete;
            month_filter.SelectedIndexChanged += month_filter_SelectedIndexChanged;
            year_fiter.SelectedIndexChanged += year_fiter_SelectedIndexChanged;
            month_filter.TextChanged += month_filter_TextChanged;
            year_fiter.TextChanged += year_fiter_TextChanged;

        }
        private bool isLoadingFilters = false;
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }

        public void greetUser(int empID)
        {
            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = "SELECT first_name, last_name FROM employee WHERE employee_id = @empID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empID", empID);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string firstName = reader["first_name"].ToString();
                            string lastName = reader["last_name"].ToString();
                            greet.Text = $"Welcome, {firstName} {lastName}";
                        }
                        else
                        {
                            greet.Text = "Welcome, Employee";
                        }
                    }
                }
            }
        }

        // todo add the deductions
        public void loadPayslips(int empID)
        {
            using (SqlConnection con = dbConnector.GetConnection())
            {
                string query = "SELECT payslip_id, pay_period_start AS [Payslip Start], pay_period_end AS [Payslip End], gross_pay, net_pay FROM payslip WHERE employee_id = @empID ORDER BY created_at DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empID", empID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    payslipGrid.DataSource = dt;
                    payslipGrid.AllowUserToAddRows = false;
                    payslipGrid.Columns["gross_pay"].HeaderText = "Gross Pay";
                    payslipGrid.Columns["net_pay"].HeaderText = "Net Pay";

                    if (payslipGrid.Columns.Contains("payslip_id"))
                        payslipGrid.Columns["payslip_id"].Visible = false;


                    if (payslipGrid.Columns.Contains("View"))
                        payslipGrid.Columns["View"].DisplayIndex = payslipGrid.Columns.Count - 1;

                    payslipGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    payslipGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    payslipGrid.AllowUserToResizeColumns = false;
                    payslipGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                    payslipGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }
        private void SetupGridColumns()
        {
            if (!payslipGrid.Columns.Contains("View"))
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
                viewButton.Name = "View";
                viewButton.HeaderText = "View Document";
                viewButton.Text = "🔍";
                viewButton.UseColumnTextForButtonValue = true;
                viewButton.FlatStyle = FlatStyle.Flat;
                payslipGrid.Columns.Add(viewButton);
            }

            payslipGrid.CellContentClick += payslipClick;
        }

        private void payslipClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && payslipGrid.Columns[e.ColumnIndex].Name == "View")
            {
                int payslipID = Convert.ToInt32(payslipGrid.Rows[e.RowIndex].Cells["payslip_id"].Value);
                string filePath = GetFilePathFromDB(payslipID);

                if (File.Exists(filePath))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
                else
                {
                    MessageBox.Show("Payslip file not found.");
                }
            }
        }

        public void reloadForm()
        {
            loadPayslips(Connector.SessionData.EmployeeID ?? 0);
        }

        private void PayslipGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (payslipGrid.Columns[e.ColumnIndex].Name == "gross_pay" ||
                payslipGrid.Columns[e.ColumnIndex].Name == "net_pay")
            {
                if (e.Value != null && decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value = $"₱{amount:N2}";
                    e.FormattingApplied = true;
                }
            }

            if (payslipGrid.Columns[e.ColumnIndex].Name == "created_at")
            {
                if (e.Value != null && DateTime.TryParse(e.Value.ToString(), out DateTime date))
                {
                    e.Value = date.ToString("yyyy-MM-dd"); // or "dd/MM/yyyy"
                    e.FormattingApplied = true;
                }
            }
        }

        public void LoadMonthFilter(ComboBox monthCombo)
        {
            isLoadingFilters = true;

            monthCombo.Items.Clear();

            string query = "SELECT DISTINCT MONTH(pay_period_start) AS MonthNum FROM payslip WHERE employee_id = @empID ORDER BY MonthNum";

            using (SqlConnection con = dbConnector.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@empID", Connector.SessionData.EmployeeID ?? 0);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int monthNum = reader.GetInt32(0);
                            string monthName = new DateTime(2025, monthNum, 1).ToString("MMMM");
                            monthCombo.Items.Add(monthName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading month filters: " + ex.Message);
                }
            }

            monthCombo.SelectedIndex = -1;
            isLoadingFilters = false;
        }

        public void LoadYearFilter(ComboBox yearCombo)
        {
            isLoadingFilters = true;

            yearCombo.Items.Clear();

            string query = "SELECT DISTINCT YEAR(pay_period_start) AS YearNum FROM payslip WHERE employee_id = @empID ORDER BY YearNum DESC";

            using (SqlConnection con = dbConnector.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@empID", Connector.SessionData.EmployeeID ?? 0);

                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int year = reader.GetInt32(0);
                            yearCombo.Items.Add(year.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading year filter: " + ex.Message);
                }
            }

            yearCombo.SelectedIndex = -1;
            isLoadingFilters = false;
        }

        private void ApplyFilters()
        {
            bool hasMonth = month_filter.SelectedItem != null;
            bool hasYear = year_fiter.SelectedItem != null;

            int? monthNumber = null;
            int? yearNumber = null;

            if (hasMonth)
            {
                string selectedMonthName = month_filter.SelectedItem.ToString();
                monthNumber = DateTime.ParseExact(selectedMonthName, "MMMM", null).Month;
            }

            if (hasYear)
            {
                yearNumber = int.Parse(year_fiter.SelectedItem.ToString());
            }

            // If no filters selected, load all payslips
            if (!hasMonth && !hasYear)
            {
                loadPayslips(Connector.SessionData.EmployeeID ?? 0);
                return;
            }

            using (SqlConnection con = dbConnector.GetConnection())
            {
                StringBuilder queryBuilder = new StringBuilder(
                    "SELECT pay_period_start AS [Payslip Start], pay_period_end AS [Payslip End], gross_pay, net_pay FROM payslip WHERE employee_id = @empID"
                );

                if (monthNumber.HasValue)
                    queryBuilder.Append(" AND MONTH(pay_period_start) = @month");

                if (yearNumber.HasValue)
                    queryBuilder.Append(" AND YEAR(pay_period_start) = @year");

                queryBuilder.Append(" ORDER BY created_at DESC");

                using (SqlCommand cmd = new SqlCommand(queryBuilder.ToString(), con))
                {
                    cmd.Parameters.AddWithValue("@empID", Connector.SessionData.EmployeeID ?? 0);

                    if (monthNumber.HasValue)
                        cmd.Parameters.AddWithValue("@month", monthNumber.Value);

                    if (yearNumber.HasValue)
                        cmd.Parameters.AddWithValue("@year", yearNumber.Value);

                    try
                    {
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        payslipGrid.DataSource = dt;

                        payslipGrid.Columns["gross_pay"].HeaderText = "Gross Pay";
                        payslipGrid.Columns["net_pay"].HeaderText = "Net Pay";
                        payslipGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        payslipGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error applying filter: " + ex.Message);
                    }
                }
            }
        }

        private void month_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingFilters)
                ApplyFilters();
        }

        private void year_fiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoadingFilters)
                ApplyFilters();
        }

        private void month_filter_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadingFilters && string.IsNullOrWhiteSpace(month_filter.Text))
                ApplyFilters();
        }

        private void year_fiter_TextChanged(object sender, EventArgs e)
        {
            if (!isLoadingFilters && string.IsNullOrWhiteSpace(year_fiter.Text))
                ApplyFilters();
        }

        private string GetFilePathFromDB(int payslipID)
        {
            try
            {
                using (SqlConnection con = dbConnector.GetConnection())
                {
                    string query = "SELECT file_path FROM payslip WHERE payslip_id = @payslipID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@payslipID", SqlDbType.Int).Value = payslipID;
                        con.Open();
                        object result = cmd.ExecuteScalar();

                        if (result == null || string.IsNullOrWhiteSpace(result.ToString()))
                        {
                            MessageBox.Show("No file path found for this payslip.", "Missing File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return string.Empty;
                        }

                        return result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving file path: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void payslipGrid_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = payslipGrid.Columns[e.ColumnIndex].Name;

                if (columnName == "View")
                {
                    payslipGrid.Cursor = Cursors.Hand;
                }
                else
                {
                    payslipGrid.Cursor = Cursors.Default;
                }
            }
            else
            {
                payslipGrid.Cursor = Cursors.Default;
            }
        }
        private void payslipGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (payslipGrid.Columns.Contains("View"))
            {
                payslipGrid.Columns["View"].DisplayIndex = payslipGrid.Columns.Count - 1;
            }
        }
    }
}
