using System.Data;
using System.Data.SqlClient;
using static Payroll_System.Connector;

namespace Payroll_System
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            this.FormClosing += Login_FormClosing;

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }


        private void btnblogin_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            var loginResult = cn.DataReceive(username.Text, password.Text); // ✅ capture tuple

            if (loginResult.isValid)
            {
                SessionData.EmployeeID = loginResult.employeeId;    

                if (loginResult.employeeId.HasValue)
                {
                    // Employee login
                    EmployeeHome ed = new EmployeeHome();
                    ed.Show();
                }
                else
                {
                    // Admin login
                    dashboard db = new dashboard();
                    db.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void reset_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword f = new ForgotPassword();
            f.Show();
            this.Hide();
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }

}
