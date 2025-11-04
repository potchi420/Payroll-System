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
            payslipGrid.CellFormatting += PayslipGrid_CellFormatting;
        }

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
            EmployeePayslips ep = new EmployeePayslips();
            this.Hide();
            ep.Show();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            EmployeePayslips ep = new EmployeePayslips();
            this.Hide();
            ep.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                string query = @"SELECT created_at, gross_pay, net_pay FROM payslip WHERE employee_id = @empID ORDER BY created_at DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empID", empID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    payslipGrid.DataSource = dt;

                    payslipGrid.Columns["created_at"].HeaderText = "Date";
                    payslipGrid.Columns["gross_pay"].HeaderText = "Gross Pay";
                    payslipGrid.Columns["net_pay"].HeaderText = "Net Pay";
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
            DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
            viewButton.Name = "View";
            viewButton.HeaderText = "View Document";
            viewButton.Text = "🔍";
            viewButton.UseColumnTextForButtonValue = true;
            payslipGrid.Columns.Add(viewButton);


            DataGridViewButtonColumn removeButton = new DataGridViewButtonColumn();
            removeButton.Name = "remove_employee_btn";
            removeButton.HeaderText = "Remove";
            removeButton.Text = "🗑️";
            removeButton.UseColumnTextForButtonValue = true;
            payslipGrid.Columns.Add(removeButton);

            payslipGrid.CellContentClick += payslipClick;
        }

        private void payslipClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int empID = Convert.ToInt32(payslipGrid.Rows[e.RowIndex].Cells["employee_id"].Value);
                string column = payslipGrid.Columns[e.ColumnIndex].Name;

                if (column == "Document")
                {
                    MessageBox.Show($"Open document for ");

                }
                else if (column == "remove_employee_btn")
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {

                        using (SqlConnection connector = dbConnector.GetConnection())
                        {
                            string deleteQuery = "DELETE FROM employee WHERE employee_id = @empID";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, connector))
                            {
                                cmd.Parameters.AddWithValue("@empID", empID);
                                connector.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Employee details deleted successfully!");
                        reloadForm();
                    }
                }
                else if (column == "edit_employee_btn")
                {
                    EditEmployee editEmployee = new EditEmployee(empID);
                    editEmployee.Show();
                    this.Show();
                    this.Hide();
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
    }
}
