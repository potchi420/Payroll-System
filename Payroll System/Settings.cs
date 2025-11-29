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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            focus_remover();
        }



        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblsystemadministration_Click(object sender, EventArgs e)
        {

        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show();
            this.Hide();
        }
        private void lblusermanagement_Click(object sender, EventArgs e)
        {
            UserManagement um = new UserManagement();
            um.Show();
            this.Hide();
        }

        private void btnacccountmanagement_Click(object sender, EventArgs e)
        {
            AccountManagements am = new AccountManagements();
            am.Show();
            this.Show();
            this.Hide();
        }

        private void btndataupdates_Click(object sender, EventArgs e)
        {

        }

        private void logobtn_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }
    }
}
