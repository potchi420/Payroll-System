using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
    public partial class attendance : Form
    {
        public attendance()
        {
            InitializeComponent();
            LoadInitialEmployees();
            LoadEmployeeNames(employee_searchbox);
            focus_remover();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static class dbConnector
        {
            private static readonly string connectionString = "Data Source=RENZ\\SQLEXPRESS;Initial Catalog=Payroll_db;Integrated Security=True;TrustServerCertificate=True";

            public static SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }

        private void home1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Show();
            this.Hide();
        }

        private void logout1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo1_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Show();
            this.Hide();
        }
        private void LoadInitialEmployees()
        {
            string query = @"SELECT a.attendance_id AS [Attendance ID], a.employee_id AS [Employee ID], a.days_worked AS [Days Worked], a.overtime_hours AS [Hours Overtimed],
                            e.first_name + ' ' + e.last_name AS FullName, a.start_date AS [Starting Date], a.end_date AS [Ending Date]" +
                            "FROM attendance a JOIN employee e ON a.employee_id = e.employee_id";
            attendance_table.DataSource = getEmployeeAttendance(query);
            // Auto-size columns to fit content
            attendance_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            attendance_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            attendance_table.AllowUserToResizeColumns = false;
            attendance_table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            attendance_table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            attendance_table.Columns["FullName"].DisplayIndex = 0;
            attendance_table.Columns["FullName"].HeaderText = "Employee Name";
        }
        private DataTable getEmployeeAttendance(string query)
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
            string query = "SELECT employee_id, (first_name + ' ' + last_name) AS FullName FROM employee";

            using (SqlConnection connector = dbConnector.GetConnection())
            {
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connector);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    searchbox.DataSource = dt;
                    searchbox.DisplayMember = "FullName";   // What user sees
                    searchbox.ValueMember = "employee_id";  // The actual value behind each item
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

        private void saveAttendanceBTN_Click(object sender, EventArgs e)
        {
            if (employee_searchbox.SelectedValue == null)
            {
                MessageBox.Show("Please select an employee.");
                return;
            }

            int employeeID = Convert.ToInt32(employee_searchbox.SelectedValue);
            int daysWorked = Convert.ToInt32(days_worked.Value);
            int overtimeHours = Convert.ToInt32(overtimed_hours.Value);
            DateTime startDate = start_date.Value.Date;
            DateTime endDate = end_date.Value.Date;

            if (daysWorked < 0 || daysWorked > 15
                )
            {
                MessageBox.Show("Days worked must be between 0 and 15.");
                return;
            }

            if (overtimeHours < 0 || overtimeHours > 70)
            {
                MessageBox.Show("Overtime hours must be between 0 and 70.");
                return;
            }

            if (endDate < startDate)
            {
                MessageBox.Show("End date cannot be earlier than start date.");
                return;
            }

            using (SqlConnection checkCon = dbConnector.GetConnection())
            {
                string checkQuery = @"SELECT COUNT(*) FROM attendance 
                              WHERE employee_id = @id AND start_date = @start AND end_date = @end";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, checkCon))
                {
                    checkCmd.Parameters.AddWithValue("@id", employeeID);
                    checkCmd.Parameters.AddWithValue("@start", startDate);
                    checkCmd.Parameters.AddWithValue("@end", endDate);

                    checkCon.Open();
                    int existing = Convert.ToInt32(checkCmd.ExecuteScalar());
                    checkCon.Close();

                    if (existing > 0)
                    {
                        MessageBox.Show("Attendance for this employee and period already exists.");
                        return;
                    }
                }
            }

            using (SqlConnection checkCon = dbConnector.GetConnection())
            {
                string overlapQuery = @"SELECT COUNT(*) FROM attendance
                            WHERE employee_id = @id
                            AND (
                                (@start BETWEEN start_date AND end_date)
                                OR (@end BETWEEN start_date AND end_date)
                                OR (start_date BETWEEN @start AND @end)
                                OR (end_date BETWEEN @start AND @end)
                            )";

                using (SqlCommand checkCmd = new SqlCommand(overlapQuery, checkCon))
                {
                    checkCmd.Parameters.AddWithValue("@id", employeeID);
                    checkCmd.Parameters.AddWithValue("@start", startDate);
                    checkCmd.Parameters.AddWithValue("@end", endDate);

                    checkCon.Open();
                    int overlapCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                    checkCon.Close();

                    if (overlapCount > 0)
                    {
                        MessageBox.Show("Attendance period overlaps with an existing record.");
                        return;
                    }
                }
            }

            // Save attendance record
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string add_emp = @"INSERT INTO attendance 
                           (employee_id, days_worked, overtime_hours, start_date, end_date) 
                           VALUES (@employee_id, @days_worked, @overtime_hours, @start_date, @end_date)";
                using (SqlCommand cmd = new SqlCommand(add_emp, connector))
                {
                    cmd.Parameters.AddWithValue("@employee_id", employeeID);
                    cmd.Parameters.AddWithValue("@days_worked", daysWorked);
                    cmd.Parameters.AddWithValue("@overtime_hours", overtimeHours);
                    cmd.Parameters.AddWithValue("@start_date", startDate);
                    cmd.Parameters.AddWithValue("@end_date", endDate);

                    connector.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Employee attendance details saved successfully!");
            LoadInitialEmployees();
            clearBTN_Click(sender, e);
        }

        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            employee_searchbox.SelectedIndex = -1;
            employee_searchbox.Text = "";

            days_worked.Value = 0; 
            overtimed_hours.Value = 0; 
            start_date.Value = DateTime.Today;
            end_date.Value = DateTime.Today;
            focus_remover();
        }
    }
}
