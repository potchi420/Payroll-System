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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnemployee_Click(object sender, EventArgs e)
        {
            Employeedashboard employeedashboard = new Employeedashboard();
            employeedashboard.Show();
            this.Show();
            this.Hide();
        }

        private void btnpayrollcenter_Click(object sender, EventArgs e)
        {
            Payroll_process payroll_process = new Payroll_process();
            payroll_process.Show();
            this.Show();
            this.Hide();
        }

        private void btnreportscenter_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblsystem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblsystem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnemployeeside_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        
    }
}
