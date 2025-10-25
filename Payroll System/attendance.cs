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
            string query = "SELECT a.attendance_id, a.employee_id, a.days_worked AS [Days Worked], a.overtimed_hour AS [Hours Overtimed], e.first_name + ' ' + e.last_name AS FullName FROM attendance a JOIN employee e ON a.employee_id = e.employee_id";
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
    }
}
