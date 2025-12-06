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
    public partial class BenefitsAdministration : Form
    {
        public BenefitsAdministration()
        {
            InitializeComponent();
            focus_remover();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BenefitsAdministration_Load(object sender, EventArgs e)
        {

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
            Logout.Execute(this);
        }

        private void assign_benefits_btn_Click(object sender, EventArgs e)
        {
            AssignBenefits assign = new AssignBenefits();
            assign.Show();
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

        private void benefit_catalog_btn_Click(object sender, EventArgs e)
        {
            BenefitCatalog benefitCatalog = new BenefitCatalog();
            benefitCatalog.Show();
            this.Show();
            this.Hide();
        }
    }
}
