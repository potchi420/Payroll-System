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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {

            connector conn = new connector();
            conn.dataSend();
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void register_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
