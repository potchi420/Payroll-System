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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Employeedashboard ed = new Employeedashboard();
            ed.Show();
            this.Show();
            this.Hide();
        }

        private void curved_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
