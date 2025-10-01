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

        private void btnreportside_Click(object sender, EventArgs e)
        {

        }

        private void btnpayrollcenter_Click(object sender, EventArgs e)
        {
            Payroll_process payroll_process = new Payroll_process();
            payroll_process.Show();
            this.Show();
        }

        private void pnlside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
