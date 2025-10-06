using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Payroll_process : Form
    {
        public Payroll_process()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void load_employee_btn_Click(object sender, EventArgs e)
        {
            // should make a function to load employee data from database
            // make some changes to the labels and textboxes to display employee data, salary, etc.
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }
    }
}
