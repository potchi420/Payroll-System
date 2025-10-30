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
            private static readonly string connectionString = "Data Source=LAPTOP-KL72FBTC\\SQLEXPRESS;Initial Catalog=payroll;Integrated Security=True;TrustServerCertificate=True";

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
            string query = "SELECT a.attendance_id, a.employee_id, a.days_worked AS [Days Worked], a.overtime_hours AS [Hours Overtimed], e.first_name + ' ' + e.last_name AS FullName FROM attendance a JOIN employee e ON a.employee_id = e.employee_id";
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

            // Code to save the new employee details to the database
            using (SqlConnection connector = dbConnector.GetConnection())
            {
                string add_emp = "INSERT INTO attendance (employee_id, days_worked, overtime_hours, attendance_date) " +
                                     "VALUES (@employee_id, @days_worked, @overtime_hours, @attendance_date)";
                using (SqlCommand cmd = new SqlCommand(add_emp, connector))
                {
                    cmd.Parameters.AddWithValue("@employee_id", Convert.ToInt32(employee_searchbox.SelectedValue));
                    cmd.Parameters.AddWithValue("@days_worked", days_worked.Value);
                    cmd.Parameters.AddWithValue("overtime_hours", overtimed_hours.Value);
                    cmd.Parameters.AddWithValue("@attendance_date", attendance_date.Value);

                    connector.Open();
                    cmd.ExecuteNonQuery();

                    
                }
            }
            MessageBox.Show("Employee Attendance details saved successfully!");
            attendance attendance = new attendance();
            attendance.Show();
            this.Show();
            this.Hide();
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
            attendance_date.Value = DateTime.Today;
            focus_remover();
        }
    }
}
