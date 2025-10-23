﻿using System;
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
    public partial class BenefitCatalog : Form
    {
        Connector cn = new Connector();
        public BenefitCatalog()
        {
            InitializeComponent();
            cn.DisplayBenefits(dataGridViewEmployees);
        }

        private void home1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void logout1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logo1_Click(object sender, EventArgs e)
        {
            dashboard db = new dashboard();
            db.Show();
            this.Show();
            this.Hide();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cn.AddBenefits(dataGridViewEmployees);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            cn.EditBenefit(dataGridViewEmployees);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cn.DeleteBenefit(dataGridViewEmployees);
        }
    }
}
