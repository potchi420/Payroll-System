using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
        {
            InitializeComponent();
        }

        private void payslip_btn_Click(object sender, EventArgs e)
        {
            EmployeePayslips ep = new EmployeePayslips();
            ep.Show();
            this.Hide();
        }

        private void account_btn_Click(object sender, EventArgs e)
        {
            AccountManagements am = new AccountManagements();
            am.Show();
            this.Hide();
        }

        private void logo_btn_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Logout.Execute(this);
        }
    }
}
