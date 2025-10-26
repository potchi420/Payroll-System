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
    public partial class AssignBenefits : Form
    {
        Connector con = new Connector();
        public AssignBenefits()
        {
            InitializeComponent();
            focus_remover();
            con.LoadEmployeeBenefits(dgv_assignbenefits);

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

        private void back_btn_Click(object sender, EventArgs e)
        {
            BenefitsAdministration benefitsAdmin = new BenefitsAdministration();
            benefitsAdmin.Show();
            this.Show();
            this.Hide();
        }
        public void focus_remover()
        {
            Label dummyFocus = new Label();
            dummyFocus.Size = new Size(0, 0);
            dummyFocus.Location = new Point(0, 0);
            this.Controls.Add(dummyFocus);
            this.ActiveControl = dummyFocus;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            con.SaveAssignedBenefits(dgv_assignbenefits);
        }

        }
}
