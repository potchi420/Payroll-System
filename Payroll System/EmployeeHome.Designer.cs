namespace Payroll_System
{
    partial class EmployeeHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeHome));
            gradientPanel1 = new GradientPanel();
            home_btn = new Label();
            logout_btn = new Label();
            label6 = new Label();
            logo_btn = new PictureBox();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            payslip_btn = new Button();
            label1 = new Label();
            benefit_catalog_btn = new Button();
            assign_benefits_description = new Label();
            label3 = new Label();
            label4 = new Label();
            account_btn = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.BackColor = Color.FromArgb(33, 145, 245);
            gradientPanel1.Controls.Add(home_btn);
            gradientPanel1.Controls.Add(logout_btn);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(logo_btn);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 33;
            // 
            // home_btn
            // 
            home_btn.AutoSize = true;
            home_btn.BackColor = Color.Transparent;
            home_btn.Cursor = Cursors.Hand;
            home_btn.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_btn.ForeColor = Color.Transparent;
            home_btn.Location = new Point(1018, 30);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(66, 24);
            home_btn.TabIndex = 24;
            home_btn.Text = "Home";
            home_btn.TextAlign = ContentAlignment.TopCenter;
            home_btn.Click += home_btn_Click;
            // 
            // logout_btn
            // 
            logout_btn.AutoSize = true;
            logout_btn.BackColor = Color.Transparent;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.Transparent;
            logout_btn.Location = new Point(1090, 30);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(85, 24);
            logout_btn.TabIndex = 24;
            logout_btn.Text = "Log Out";
            logout_btn.TextAlign = ContentAlignment.TopCenter;
            logout_btn.Click += logout_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(82, 30);
            label6.Name = "label6";
            label6.Size = new Size(258, 24);
            label6.TabIndex = 23;
            label6.Text = "PCU PAYROLL SYSTEM";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo_btn
            // 
            logo_btn.BackColor = Color.Transparent;
            logo_btn.Cursor = Cursors.Hand;
            logo_btn.Image = Properties.Resources.icon;
            logo_btn.Location = new Point(0, 3);
            logo_btn.Name = "logo_btn";
            logo_btn.Size = new Size(76, 75);
            logo_btn.SizeMode = PictureBoxSizeMode.StretchImage;
            logo_btn.TabIndex = 22;
            logo_btn.TabStop = false;
            logo_btn.Click += logo_btn_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(58, 154);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(709, 15);
            linkLabel1.TabIndex = 35;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 114);
            label2.Name = "label2";
            label2.Size = new Size(342, 40);
            label2.TabIndex = 34;
            label2.Text = "Employee Dashboard";
            // 
            // payslip_btn
            // 
            payslip_btn.Cursor = Cursors.Hand;
            payslip_btn.FlatStyle = FlatStyle.Flat;
            payslip_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payslip_btn.Image = (Image)resources.GetObject("payslip_btn.Image");
            payslip_btn.ImageAlign = ContentAlignment.MiddleLeft;
            payslip_btn.Location = new Point(61, 205);
            payslip_btn.Name = "payslip_btn";
            payslip_btn.Padding = new Padding(30, 0, 0, 0);
            payslip_btn.Size = new Size(700, 106);
            payslip_btn.TabIndex = 36;
            payslip_btn.Text = "                               \r\n                  Payslips \r\n\r\n\r\n";
            payslip_btn.TextAlign = ContentAlignment.MiddleLeft;
            payslip_btn.Click += payslip_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(169, 263);
            label1.Name = "label1";
            label1.Size = new Size(522, 17);
            label1.TabIndex = 38;
            label1.Text = "a comprehensive list or guide that outlines the perks, services, and rewards available";
            // 
            // benefit_catalog_btn
            // 
            benefit_catalog_btn.BackColor = SystemColors.Control;
            benefit_catalog_btn.Cursor = Cursors.Hand;
            benefit_catalog_btn.FlatStyle = FlatStyle.Flat;
            benefit_catalog_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefit_catalog_btn.Image = (Image)resources.GetObject("benefit_catalog_btn.Image");
            benefit_catalog_btn.ImageAlign = ContentAlignment.MiddleLeft;
            benefit_catalog_btn.Location = new Point(61, 205);
            benefit_catalog_btn.Name = "benefit_catalog_btn";
            benefit_catalog_btn.Padding = new Padding(30, 0, 0, 0);
            benefit_catalog_btn.Size = new Size(700, 106);
            benefit_catalog_btn.TabIndex = 37;
            benefit_catalog_btn.Text = "                  Benefit Catalog\r\n\r\n";
            benefit_catalog_btn.TextAlign = ContentAlignment.MiddleLeft;
            benefit_catalog_btn.UseVisualStyleBackColor = true;
            // 
            // assign_benefits_description
            // 
            assign_benefits_description.AutoSize = true;
            assign_benefits_description.Cursor = Cursors.Hand;
            assign_benefits_description.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            assign_benefits_description.Location = new Point(169, 263);
            assign_benefits_description.Name = "assign_benefits_description";
            assign_benefits_description.Size = new Size(527, 17);
            assign_benefits_description.TabIndex = 39;
            assign_benefits_description.Text = "the process of allocating specific perks, rewards, or entitlements to eligible employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial", 9.75F);
            label3.Location = new Point(169, 263);
            label3.Name = "label3";
            label3.Size = new Size(385, 16);
            label3.TabIndex = 40;
            label3.Text = "View detailed breakdowns of your salary, deductions, and net pay";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial", 9.75F);
            label4.Location = new Point(169, 406);
            label4.Name = "label4";
            label4.Size = new Size(450, 16);
            label4.TabIndex = 42;
            label4.Text = "Manage your login credentials and update your account information securely.";
            // 
            // account_btn
            // 
            account_btn.Cursor = Cursors.Hand;
            account_btn.FlatStyle = FlatStyle.Flat;
            account_btn.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            account_btn.Image = (Image)resources.GetObject("account_btn.Image");
            account_btn.ImageAlign = ContentAlignment.MiddleLeft;
            account_btn.Location = new Point(61, 348);
            account_btn.Name = "account_btn";
            account_btn.Padding = new Padding(30, 0, 0, 0);
            account_btn.Size = new Size(700, 106);
            account_btn.TabIndex = 41;
            account_btn.Text = "                               \r\n                  Account Management\r\n\r\n\r\n";
            account_btn.TextAlign = ContentAlignment.MiddleLeft;
            account_btn.Click += account_btn_Click;
            // 
            // EmployeeHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(label4);
            Controls.Add(account_btn);
            Controls.Add(label3);
            Controls.Add(payslip_btn);
            Controls.Add(label1);
            Controls.Add(benefit_catalog_btn);
            Controls.Add(assign_benefits_description);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(gradientPanel1);
            Name = "EmployeeHome";
            Text = "EmployeeDashboard";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home_btn;
        private Label logout_btn;
        private Label label6;
        private PictureBox logo_btn;
        private LinkLabel linkLabel1;
        private Label label2;
        private Button payslip_btn;
        private Label label1;
        private Button benefit_catalog_btn;
        private Label assign_benefits_description;
        private Label label3;
        private Label label4;
        private Button account_btn;
    }
}