namespace Payroll_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            pnlcenter = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            btnsettings = new Button();
            btnbenefits = new Button();
            btntax = new Button();
            btnreportscenter = new Button();
            btnpayrollcenter = new Button();
            btnemployeecenter = new Button();
            logo = new PictureBox();
            label8 = new Label();
            logout = new Label();
            home = new Label();
            gradientPanel1 = new GradientPanel();
            pnlcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlcenter
            // 
            pnlcenter.BackColor = SystemColors.Control;
            pnlcenter.Controls.Add(panel4);
            pnlcenter.Controls.Add(panel3);
            pnlcenter.Controls.Add(panel2);
            pnlcenter.Controls.Add(panel1);
            pnlcenter.Controls.Add(dataGridView1);
            pnlcenter.Controls.Add(btnsettings);
            pnlcenter.Controls.Add(btnbenefits);
            pnlcenter.Controls.Add(btntax);
            pnlcenter.Controls.Add(btnreportscenter);
            pnlcenter.Controls.Add(btnpayrollcenter);
            pnlcenter.Controls.Add(btnemployeecenter);
            pnlcenter.Location = new Point(-3, 69);
            pnlcenter.Name = "pnlcenter";
            pnlcenter.Size = new Size(1420, 589);
            pnlcenter.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(618, 24);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 145);
            panel4.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.Location = new Point(926, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 145);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(333, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 145);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(32, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 145);
            panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 351);
            dataGridView1.TabIndex = 6;
            // 
            // btnsettings
            // 
            btnsettings.BackColor = SystemColors.ButtonFace;
            btnsettings.Cursor = Cursors.Hand;
            btnsettings.Font = new Font("Arial", 9F);
            btnsettings.Image = (Image)resources.GetObject("btnsettings.Image");
            btnsettings.Location = new Point(998, 400);
            btnsettings.Margin = new Padding(10);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(170, 170);
            btnsettings.TabIndex = 5;
            btnsettings.Text = "Settings\r\n\r\n";
            btnsettings.TextAlign = ContentAlignment.BottomCenter;
            btnsettings.UseVisualStyleBackColor = false;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnbenefits
            // 
            btnbenefits.BackColor = SystemColors.ButtonFace;
            btnbenefits.Cursor = Cursors.Hand;
            btnbenefits.Font = new Font("Arial", 9F);
            btnbenefits.Image = (Image)resources.GetObject("btnbenefits.Image");
            btnbenefits.Location = new Point(808, 400);
            btnbenefits.Margin = new Padding(10);
            btnbenefits.Name = "btnbenefits";
            btnbenefits.Size = new Size(170, 170);
            btnbenefits.TabIndex = 4;
            btnbenefits.Text = "Benefits\r\nAdministration\r\n\r\n";
            btnbenefits.TextAlign = ContentAlignment.BottomCenter;
            btnbenefits.UseVisualStyleBackColor = false;
            btnbenefits.Click += btnbenefits_Click;
            // 
            // btntax
            // 
            btntax.BackColor = SystemColors.ButtonFace;
            btntax.Cursor = Cursors.Hand;
            btntax.Font = new Font("Arial", 9F);
            btntax.Image = (Image)resources.GetObject("btntax.Image");
            btntax.Location = new Point(618, 400);
            btntax.Margin = new Padding(10);
            btntax.Name = "btntax";
            btntax.Size = new Size(170, 170);
            btntax.TabIndex = 3;
            btntax.Text = "Tax Filings\r\n\r\n";
            btntax.TextAlign = ContentAlignment.BottomCenter;
            btntax.UseVisualStyleBackColor = false;
            // 
            // btnreportscenter
            // 
            btnreportscenter.BackColor = SystemColors.ButtonFace;
            btnreportscenter.Cursor = Cursors.Hand;
            btnreportscenter.Font = new Font("Arial", 9F);
            btnreportscenter.Image = (Image)resources.GetObject("btnreportscenter.Image");
            btnreportscenter.Location = new Point(998, 219);
            btnreportscenter.Margin = new Padding(10);
            btnreportscenter.Name = "btnreportscenter";
            btnreportscenter.Size = new Size(170, 170);
            btnreportscenter.TabIndex = 2;
            btnreportscenter.Text = "Reports\r\n\r\n";
            btnreportscenter.TextAlign = ContentAlignment.BottomCenter;
            btnreportscenter.UseVisualStyleBackColor = false;
            btnreportscenter.Click += btnreportscenter_Click;
            // 
            // btnpayrollcenter
            // 
            btnpayrollcenter.BackColor = SystemColors.ButtonFace;
            btnpayrollcenter.Cursor = Cursors.Hand;
            btnpayrollcenter.Font = new Font("Arial", 9F);
            btnpayrollcenter.Image = (Image)resources.GetObject("btnpayrollcenter.Image");
            btnpayrollcenter.Location = new Point(808, 219);
            btnpayrollcenter.Margin = new Padding(10);
            btnpayrollcenter.Name = "btnpayrollcenter";
            btnpayrollcenter.Size = new Size(170, 170);
            btnpayrollcenter.TabIndex = 1;
            btnpayrollcenter.Text = "Payroll\r\nProcessing\r\n\r\n";
            btnpayrollcenter.TextAlign = ContentAlignment.BottomCenter;
            btnpayrollcenter.UseVisualStyleBackColor = false;
            btnpayrollcenter.Click += btnpayrollcenter_Click;
            // 
            // btnemployeecenter
            // 
            btnemployeecenter.BackColor = SystemColors.ButtonFace;
            btnemployeecenter.Cursor = Cursors.Hand;
            btnemployeecenter.Font = new Font("Arial", 9F);
            btnemployeecenter.Image = (Image)resources.GetObject("btnemployeecenter.Image");
            btnemployeecenter.Location = new Point(618, 219);
            btnemployeecenter.Margin = new Padding(10);
            btnemployeecenter.Name = "btnemployeecenter";
            btnemployeecenter.Size = new Size(170, 170);
            btnemployeecenter.TabIndex = 0;
            btnemployeecenter.Text = "Employee \r\nManagement\r\n\r\n";
            btnemployeecenter.TextAlign = ContentAlignment.BottomCenter;
            btnemployeecenter.UseVisualStyleBackColor = false;
            btnemployeecenter.Click += btnemployee_Click;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(82, 30);
            label8.Name = "label8";
            label8.Size = new Size(258, 24);
            label8.TabIndex = 23;
            label8.Text = "PCU PAYROLL SYSTEM";
            label8.TextAlign = ContentAlignment.TopCenter;
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
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home);
            gradientPanel1.Controls.Add(logout);
            gradientPanel1.Controls.Add(label8);
            gradientPanel1.Controls.Add(logo);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, -2);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 4;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(pnlcenter);
            Name = "dashboard";
            Text = "dashboard";
            pnlcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlcenter;
        private Button btnpayrollcenter;
        private Button btnemployeecenter;
        private Button btnreportscenter;
        private Button btntax;
        private Button btnsettings;
        private Button btnbenefits;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private PictureBox logo;
        private Label label8;
        private Label logout;
        private Label home;
        private GradientPanel gradientPanel1;
    }
}