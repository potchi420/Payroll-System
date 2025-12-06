using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace Payroll_System
{
    public partial class Employeedashboard : Form
    {
        private string query;

        public Employeedashboard()
        {
            InitializeComponent();
            LoadInitialEmployees();
            SetupGridColumns();
            LoadEmployeeNames(searchbox);
            employeeEntriesCount();
            dataGridViewEmployees.CellMouseMove += dataGridViewEmployees_CellMouseMove;
            searchbox.KeyDown += searchbox_KeyDown;
        }

        //change the connection string as per your sql server
        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void logo_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }

        private void btnaddemployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            this.Show();
            this.Hide();
        }


        private void LoadInitialEmployees()
        {
            string query = @"
            SELECT 
                e.employee_id AS [Employee ID],
                (e.first_name + ' ' + e.last_name) AS [Full Name],
                e.address AS [Address],
                e.[Contact no.] AS [Contact Number],
                d.department_name AS [Department],
                e.salary AS [Salary],
                e.last_update AS [Last Updated],
                e.email AS [Email]
            FROM employee e
            INNER JOIN department d ON e.department_id = d.department_id
            WHERE e.is_active = 1";


            dataGridViewEmployees.DataSource = GetEmployees(query);
            // Auto-size columns to fit content
            dataGridViewEmployees.Columns["Salary"].DefaultCellStyle.Format = "C2";
            dataGridViewEmployees.Columns["Salary"].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewEmployees.AllowUserToResizeColumns = false;
            dataGridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void SetupGridColumns()
        {
            // Add Edit Button Column
            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "edit_employee_btn";
            editButton.HeaderText = "Edit";
            editButton.Text = "✏️";
            /*
            editButton.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#e6ae22"); 
            editButton.DefaultCellStyle.ForeColor = Color.White;*/
            editButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(editButton);

            // Add Remove Button Column
            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "remove_employee_btn";
            removeButton.HeaderText = "Remove";
            removeButton.Text = "🗑️";
            /*
            removeButton.DefaultCellStyle.BackColor = Color.Red;
            removeButton.DefaultCellStyle.ForeColor = Color.White;*/
            removeButton.UseColumnTextForButtonValue = true;
            dataGridViewEmployees.Columns.Add(removeButton);

            editButton.FlatStyle = FlatStyle.Flat;
            removeButton.FlatStyle = FlatStyle.Flat;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string column = dataGridViewEmployees.Columns[e.ColumnIndex].Name;

            if (column == "remove_employee_btn" || column == "edit_employee_btn")
            {
                object idValue = dataGridViewEmployees.Rows[e.RowIndex].Cells["Employee ID"].Value;
                if (idValue == null || idValue == DBNull.Value) return;

                int empID = Convert.ToInt32(idValue);

                if (column == "remove_employee_btn")
                {
                    DialogResult result = MessageBox.Show(
                        "Are you sure you want to deactivate this employee?",
                        "Confirm Deactivate",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connector = dbConnector.GetConnection())
                        {
                            string deleteLogin = "DELETE FROM login WHERE employee_id = @empID";
                            using (SqlCommand cmd = new SqlCommand(deleteLogin, connector))
                            {
                                cmd.Parameters.AddWithValue("@empID", empID);
                                connector.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        using (SqlConnection connector = dbConnector.GetConnection())
                        {
                            string deactivateQuery = "UPDATE employee SET is_active = 0 WHERE employee_id = @empID";
                            using (SqlCommand cmd = new SqlCommand(deactivateQuery, connector))
                            {
                                cmd.Parameters.AddWithValue("@empID", empID);
                                connector.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Employee has been deactivated successfully!");
                        reloadForm();
                    }
                }
                else if (column == "edit_employee_btn")
                {
                    EditEmployee editEmployee = new EditEmployee(empID);
                    editEmployee.Show();
                    this.Hide();
                }
            }
        }

        private DataTable GetEmployees(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                adapter.Fill(dt);
            }
            return dt;
        }

        public void LoadEmployeeNames(ComboBox searchbox)
        {
            string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName " +
                           "FROM employee WHERE is_active = 1";

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    searchbox.DataSource = dt;
                    searchbox.DisplayMember = "FullName";
                    searchbox.ValueMember = "employee_id";
                    searchbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    searchbox.AutoCompleteSource = AutoCompleteSource.ListItems;
                    searchbox.SelectedIndex = -1;
                    searchbox.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee names: " + ex.Message);
                }
            }
        }
        private void dataGridViewEmployees_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewEmployees.Columns[e.ColumnIndex].Name;

                if (columnName == "edit_employee_btn" || columnName == "remove_employee_btn")
                {
                    dataGridViewEmployees.Cursor = Cursors.Hand;
                }
                else
                {
                    dataGridViewEmployees.Cursor = Cursors.Default;
                }
            }
            else
            {
                dataGridViewEmployees.Cursor = Cursors.Default;
            }
        }
        public void reloadForm()
        {
            LoadInitialEmployees();
        }

        private void searchbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string selectedName = searchbox.Text.Trim().ToLower();
                dataGridViewEmployees.ClearSelection();

                foreach (DataGridViewRow row in dataGridViewEmployees.Rows)
                {
                    if (row.Cells["Full Name"].Value != null)
                    {
                        string fullName = row.Cells["Full Name"].Value.ToString().ToLower();

                        if (fullName == selectedName)
                        {
                            row.Selected = true;
                            dataGridViewEmployees.FirstDisplayedScrollingRowIndex = row.Index;
                            break;
                        }
                    }
                }

                e.Handled = true;
            }
        }

        public void employeeEntriesCount() 
        { 
            string query = "SELECT COUNT(*) FROM employee";
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, connector))
                {
                    connector.Open();
                    int count = (int)cmd.ExecuteScalar();
                    employee_entries.Text = "Showing " + count.ToString() + " Entries";
                }
            }
        }
    }
}