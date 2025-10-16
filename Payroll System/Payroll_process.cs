using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            Connector cn = new Connector();
            cn.LoadEmployeeNames(cmbname);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void load_employee_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbname.SelectedValue != null && int.TryParse(cmbname.SelectedValue.ToString(), out int empID))
                {
                    Connector cn = new Connector();
                    cn.DisplayEmployeeSalary(empID, basic_salary_value,sss_value); // basic_salary_value = your Label
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


    }
}
