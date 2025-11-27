namespace Payroll_System
{
    partial class assignEmployeeBenefit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignEmployeeBenefit));
            gradientPanel1 = new GradientPanel();
            home = new Label();
            logout = new Label();
            label5 = new Label();
            logo = new PictureBox();
            linkLabel1 = new LinkLabel();
            benefits_administration_label = new Label();
            empBox = new ComboBox();
            benefitsList = new CheckedListBox();
            search_lb = new Label();
            label1 = new Label();
            gradientPanel2 = new GradientPanel();
            save_btn = new Button();
            back_btn = new Button();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            gradientPanel2.SuspendLayout();
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
            gradientPanel1.TabIndex = 29;
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
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(63, 134);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(1078, 15);
            linkLabel1.TabIndex = 40;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // benefits_administration_label
            // 
            benefits_administration_label.AutoSize = true;
            benefits_administration_label.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            benefits_administration_label.Location = new Point(60, 105);
            benefits_administration_label.Name = "benefits_administration_label";
            benefits_administration_label.Size = new Size(314, 29);
            benefits_administration_label.TabIndex = 39;
            benefits_administration_label.Text = "Assign Employee Benefits";
            // 
            // empBox
            // 
            empBox.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            empBox.FormattingEnabled = true;
            empBox.Location = new Point(157, 40);
            empBox.Name = "empBox";
            empBox.Size = new Size(313, 26);
            empBox.TabIndex = 31;
            // 
            // benefitsList
            // 
            benefitsList.BackColor = SystemColors.ControlLightLight;
            benefitsList.Cursor = Cursors.Hand;
            benefitsList.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            benefitsList.FormattingEnabled = true;
            benefitsList.Location = new Point(157, 83);
            benefitsList.Name = "benefitsList";
            benefitsList.Size = new Size(313, 193);
            benefitsList.TabIndex = 30;
            // 
            // search_lb
            // 
            search_lb.AutoSize = true;
            search_lb.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            search_lb.Location = new Point(55, 44);
            search_lb.Name = "search_lb";
            search_lb.Size = new Size(91, 19);
            search_lb.TabIndex = 32;
            search_lb.Text = "Employee:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 83);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 41;
            label1.Text = "Benefits:";
            // 
            // gradientPanel2
            // 
            gradientPanel2.BorderStyle = BorderStyle.FixedSingle;
            gradientPanel2.Controls.Add(search_lb);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(empBox);
            gradientPanel2.Controls.Add(benefitsList);
            gradientPanel2.gradientBottom = Color.Empty;
            gradientPanel2.gradientTop = Color.Empty;
            gradientPanel2.Location = new Point(329, 206);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(552, 309);
            gradientPanel2.TabIndex = 42;
            // 
            // save_btn
            // 
            save_btn.Cursor = Cursors.Hand;
            save_btn.Font = new Font("Arial", 11.25F);
            save_btn.Location = new Point(760, 531);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(121, 32);
            save_btn.TabIndex = 47;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Cursor = Cursors.Hand;
            back_btn.Font = new Font("Arial", 11.25F);
            back_btn.Location = new Point(632, 531);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(122, 32);
            back_btn.TabIndex = 48;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // assignEmployeeBenefit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(save_btn);
            Controls.Add(back_btn);
            Controls.Add(gradientPanel2);
            Controls.Add(linkLabel1);
            Controls.Add(benefits_administration_label);
            Controls.Add(gradientPanel1);
            Name = "assignEmployeeBenefit";
            Text = "assignEmployeeBenefit";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label5;
        private PictureBox logo;
        private LinkLabel linkLabel1;
        private Label benefits_administration_label;
        private ComboBox empBox;
        private CheckedListBox benefitsList;
        private Label search_lb;
        private Label label1;
        private GradientPanel gradientPanel2;
        private Button save_btn;
        private Button back_btn;
    }
}