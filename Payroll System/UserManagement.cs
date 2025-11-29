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
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
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
    }
}
