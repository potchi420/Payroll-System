namespace Payroll_System
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            label8 = new Label();
            pictureBox5 = new PictureBox();
            home = new Label();
            logout = new Label();
            label6 = new Label();
            logo = new PictureBox();
            btnusermanagement = new Button();
            lblusermanagement = new Label();
            btndataupdates = new Button();
            lbldataupdates = new Label();
            btnacccountmanagement = new Button();
            lblstructuremanagement = new Label();
            lblsystemadministration = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(82, 30);
            label8.Name = "label8";
            label8.Size = new Size(258, 24);
            label8.TabIndex = 23;
            label8.Text = "PCU PAYROLL SYSTEM";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.icon;
            pictureBox5.Location = new Point(0, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 75);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // home
            // 
            home.AutoSize = true;
            home.BackColor = Color.Transparent;
            home.Cursor = Cursors.Hand;
            home.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            logout.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout.ForeColor = Color.Transparent;
            logout.Location = new Point(1090, 30);
            logout.Name = "logout";
            logout.Size = new Size(85, 24);
            logout.TabIndex = 24;
            logout.Text = "Log Out";
            logout.TextAlign = ContentAlignment.TopCenter;
            logout.Click += logout_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(82, 30);
            label6.Name = "label6";
            label6.Size = new Size(258, 24);
            label6.TabIndex = 23;
            label6.Text = "PCU PAYROLL SYSTEM";
            label6.TextAlign = ContentAlignment.TopCenter;
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
            // btnusermanagement
            // 
            btnusermanagement.BackColor = SystemColors.Control;
            btnusermanagement.FlatStyle = FlatStyle.Flat;
            btnusermanagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusermanagement.Image = (Image)resources.GetObject("btnusermanagement.Image");
            btnusermanagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnusermanagement.Location = new Point(79, 158);
            btnusermanagement.Name = "btnusermanagement";
            btnusermanagement.Size = new Size(709, 106);
            btnusermanagement.TabIndex = 0;
            btnusermanagement.Text = "            \r\n                    User Management\r\n\r\n\r\n";
            btnusermanagement.TextAlign = ContentAlignment.TopLeft;
            btnusermanagement.UseVisualStyleBackColor = false;
            btnusermanagement.Click += btnusermanagement_Click;
            // 
            // lblusermanagement
            // 
            lblusermanagement.AutoSize = true;
            lblusermanagement.BackColor = SystemColors.Control;
            lblusermanagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusermanagement.Location = new Point(167, 213);
            lblusermanagement.Name = "lblusermanagement";
            lblusermanagement.Size = new Size(356, 17);
            lblusermanagement.TabIndex = 1;
            lblusermanagement.Text = "Create and manage user accounts and their access levels.\r\n";
            lblusermanagement.Click += lblusermanagement_Click;
            // 
            // btndataupdates
            // 
            btndataupdates.BackColor = SystemColors.Control;
            btndataupdates.FlatStyle = FlatStyle.Flat;
            btndataupdates.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndataupdates.Image = (Image)resources.GetObject("btndataupdates.Image");
            btndataupdates.ImageAlign = ContentAlignment.MiddleLeft;
            btndataupdates.Location = new Point(79, 403);
            btndataupdates.Name = "btndataupdates";
            btndataupdates.Size = new Size(709, 106);
            btndataupdates.TabIndex = 2;
            btndataupdates.Text = "           \r\n                    Data Updates\r\n\r\n\r\n";
            btndataupdates.TextAlign = ContentAlignment.TopLeft;
            btndataupdates.UseVisualStyleBackColor = false;
            btndataupdates.Click += btndataupdates_Click;
            // 
            // lbldataupdates
            // 
            lbldataupdates.AutoSize = true;
            lbldataupdates.BackColor = SystemColors.Control;
            lbldataupdates.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldataupdates.Location = new Point(167, 459);
            lbldataupdates.Name = "lbldataupdates";
            lbldataupdates.Size = new Size(537, 34);
            lbldataupdates.TabIndex = 3;
            lbldataupdates.Text = "Review and update data tables to comply with new system or government regulations.\r\n\r\n";
            // 
            // btnacccountmanagement
            // 
            btnacccountmanagement.BackColor = SystemColors.Control;
            btnacccountmanagement.FlatStyle = FlatStyle.Flat;
            btnacccountmanagement.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnacccountmanagement.Image = (Image)resources.GetObject("btnacccountmanagement.Image");
            btnacccountmanagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnacccountmanagement.Location = new Point(79, 279);
            btnacccountmanagement.Name = "btnacccountmanagement";
            btnacccountmanagement.Size = new Size(709, 106);
            btnacccountmanagement.TabIndex = 4;
            btnacccountmanagement.Text = "           \r\n                    Account Management\r\n\r\n\r\n\r\n";
            btnacccountmanagement.TextAlign = ContentAlignment.TopLeft;
            btnacccountmanagement.UseVisualStyleBackColor = false;
            btnacccountmanagement.Click += btnacccountmanagement_Click;
            // 
            // lblstructuremanagement
            // 
            lblstructuremanagement.AutoSize = true;
            lblstructuremanagement.BackColor = SystemColors.Control;
            lblstructuremanagement.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblstructuremanagement.Location = new Point(167, 336);
            lblstructuremanagement.Name = "lblstructuremanagement";
            lblstructuremanagement.Size = new Size(238, 34);
            lblstructuremanagement.TabIndex = 5;
            lblstructuremanagement.Text = "Edit relevant info about your account.\r\n\r\n";
            lblstructuremanagement.Click += label1_Click;
            // 
            // lblsystemadministration
            // 
            lblsystemadministration.AutoSize = true;
            lblsystemadministration.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsystemadministration.Location = new Point(62, 96);
            lblsystemadministration.Name = "lblsystemadministration";
            lblsystemadministration.Size = new Size(273, 32);
            lblsystemadministration.TabIndex = 6;
            lblsystemadministration.Text = "  System Administration";
            lblsystemadministration.Click += lblsystemadministration_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Transparent;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.FromArgb(133, 133, 133);
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(79, 128);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(709, 15);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = resources.GetString("linkLabel1.Text");
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1184, 651);
            Controls.Add(linkLabel1);
            Controls.Add(lblstructuremanagement);
            Controls.Add(lblsystemadministration);
            Controls.Add(btnacccountmanagement);
            Controls.Add(lblusermanagement);
            Controls.Add(lbldataupdates);
            Controls.Add(btnusermanagement);
            Controls.Add(btndataupdates);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private PictureBox pictureBox5;
        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label6;
        private PictureBox logo;
        private Button btnusermanagement;
        private Label lblusermanagement;
        private Button btndataupdates;
        private Label lbldataupdates;
        private Button btnacccountmanagement;
        private Label lblstructuremanagement;
        private Label lblsystemadministration;
        private LinkLabel linkLabel1;
    }
}