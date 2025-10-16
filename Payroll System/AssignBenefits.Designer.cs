﻿namespace Payroll_System
{
    partial class AssignBenefits
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignBenefits));
            gradientPanel1 = new GradientPanel();
            home = new Label();
            logout = new Label();
            label5 = new Label();
            logo = new PictureBox();
            benefits_administration_label = new Label();
            linkLabel1 = new LinkLabel();
            dataGridView1 = new DataGridView();
            curved_panel = new GradientPanel();
            remove_btn = new Button();
            edit_btn = new Button();
            add_btn = new Button();
            textBox1 = new TextBox();
            search_lb = new Label();
            save_btn = new Button();
            back_btn = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            curved_panel.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home);
            gradientPanel1.Controls.Add(logout);
            gradientPanel1.Controls.Add(label5);
            gradientPanel1.Controls.Add(logo);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 28;
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home.ForeColor = Color.Transparent;
            home.Location = new Point(1018, 30);
            home.Name = "home";
            home.Size = new Size(66, 24);
            home.TabIndex = 24;
            home.Text = "Home";
            home.TextAlign = ContentAlignment.TopCenter;
            home.Click += home_Click;
            // 
            // logout
            // 
            logout.AutoSize = true;
            logout.BackColor = Color.Transparent;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(1090, 30);
            logout.Name = "logout";
            logout.Size = new Size(85, 24);
            logout.TabIndex = 24;
            logout.Text = "Log Out";
            logout.TextAlign = ContentAlignment.TopCenter;
            logout.Click += logout_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(82, 30);
            label5.Name = "label5";
            label5.Size = new Size(258, 24);
            label5.TabIndex = 23;
            label5.Text = "PCU PAYROLL SYSTEM";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Cursor = Cursors.Hand;
            logo.Image = Properties.Resources.icon;
            logo.Location = new Point(0, 3);
            logo.Name = "logo";
            logo.Size = new Size(76, 75);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 22;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(60, 105);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(194, 29);
            benefits_administration_label.TabIndex = 31;
            benefits_administration_label.Text = "Assign Benefits";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(63, 134);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(596, 259);
            dataGridView1.TabIndex = 0;
            // 
            // curved_panel
            // 
            curved_panel.BorderStyle = BorderStyle.FixedSingle;
            curved_panel.Controls.Add(remove_btn);
            curved_panel.Controls.Add(edit_btn);
            curved_panel.Controls.Add(add_btn);
            curved_panel.Controls.Add(textBox1);
            curved_panel.Controls.Add(search_lb);
            curved_panel.Controls.Add(dataGridView1);
            curved_panel.gradientBottom = Color.Empty;
            curved_panel.gradientTop = Color.Empty;
            curved_panel.Location = new Point(154, 191);
            curved_panel.Name = "curved_panel";
            curved_panel.Size = new Size(886, 351);
            curved_panel.TabIndex = 44;
            // 
            // remove_btn
            // 
            remove_btn.Font = new Font("Arial", 11.25F);
            remove_btn.Location = new Point(703, 189);
            remove_btn.Name = "remove_btn";
            remove_btn.Size = new Size(130, 43);
            remove_btn.TabIndex = 33;
            remove_btn.Text = "Remove Benefit";
            remove_btn.UseVisualStyleBackColor = true;
            // 
            // edit_btn
            // 
            edit_btn.Font = new Font("Arial", 11.25F);
            edit_btn.Location = new Point(703, 128);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(130, 43);
            edit_btn.TabIndex = 32;
            edit_btn.Text = "Edit Benefit";
            edit_btn.UseVisualStyleBackColor = true;
            // 
            // add_btn
            // 
            add_btn.Font = new Font("Arial", 11.25F);
            add_btn.Location = new Point(703, 66);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(130, 43);
            add_btn.TabIndex = 31;
            add_btn.Text = "Add Benefit";
            add_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(165, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 21);
            textBox1.TabIndex = 30;
            // 
            // search_lb
            // 
            search_lb.AutoSize = true;
            search_lb.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lb.Location = new Point(36, 27);
            search_lb.Name = "search_lb";
            search_lb.Size = new Size(123, 16);
            search_lb.TabIndex = 29;
            search_lb.Text = "Employee Search:";
            // 
            // save_btn
            // 
            save_btn.Font = new Font("Arial", 11.25F);
            save_btn.Location = new Point(910, 559);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(130, 43);
            save_btn.TabIndex = 35;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            // 
            // back_btn
            // 
            back_btn.Font = new Font("Arial", 11.25F);
            back_btn.Location = new Point(764, 559);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(130, 43);
            back_btn.TabIndex = 45;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // AssignBenefits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(back_btn);
            Controls.Add(save_btn);
            Controls.Add(curved_panel);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(gradientPanel1);
            Name = "AssignBenefits";
            Text = "AssignBenefits";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            curved_panel.ResumeLayout(false);
            curved_panel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label5;
        private PictureBox logo;
        private Label benefits_administration_label;
        private LinkLabel linkLabel1;
        private DataGridView dataGridView1;
        private GradientPanel curved_panel;
        private Button add_btn;
        private TextBox textBox1;
        private Label search_lb;
        private Button save_btn;
        private Button remove_btn;
        private Button edit_btn;
        private Button back_btn;
    }
}