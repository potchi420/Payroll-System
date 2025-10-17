namespace Payroll_System
{
    partial class DataUpdates
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
            home = new Label();
            logout = new Label();
            label8 = new Label();
            logo = new PictureBox();
            pnl = new Panel();
            lbldataupdates = new Label();
            lblsss = new Label();
            lblphilhealth = new Label();
            lblpagibig = new Label();
            lblpercent = new Label();
            lblpercentmid = new Label();
            lblpercentbottom = new Label();
            btnsave = new Button();
            btnback = new Button();
            pbtop = new ProgressBar();
            pbmid = new ProgressBar();
            pbbottom = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnl.SuspendLayout();
            SuspendLayout();
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
            // pnl
            // 
            pnl.Controls.Add(lblpercentbottom);
            pnl.Controls.Add(lblpercentmid);
            pnl.Controls.Add(lblpercent);
            pnl.Controls.Add(pbbottom);
            pnl.Controls.Add(lblpagibig);
            pnl.Controls.Add(pbmid);
            pnl.Controls.Add(lblphilhealth);
            pnl.Controls.Add(pbtop);
            pnl.Controls.Add(lblsss);
            pnl.Location = new Point(153, 82);
            pnl.Name = "pnl";
            pnl.Size = new Size(661, 441);
            pnl.TabIndex = 0;
            // 
            // lbldataupdates
            // 
            lbldataupdates.AutoSize = true;
            lbldataupdates.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldataupdates.Location = new Point(156, 34);
            lbldataupdates.Name = "lbldataupdates";
            lbldataupdates.Size = new Size(229, 45);
            lbldataupdates.TabIndex = 0;
            lbldataupdates.Text = "Data Updates";
            // 
            // lblsss
            // 
            lblsss.AutoSize = true;
            lblsss.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblsss.Location = new Point(3, 17);
            lblsss.Name = "lblsss";
            lblsss.Size = new Size(71, 45);
            lblsss.TabIndex = 1;
            lblsss.Text = "SSS";
            lblsss.Click += label1_Click;
            // 
            // lblphilhealth
            // 
            lblphilhealth.AutoSize = true;
            lblphilhealth.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblphilhealth.Location = new Point(8, 171);
            lblphilhealth.Name = "lblphilhealth";
            lblphilhealth.Size = new Size(177, 45);
            lblphilhealth.TabIndex = 3;
            lblphilhealth.Text = "Philhealth";
            // 
            // lblpagibig
            // 
            lblpagibig.AutoSize = true;
            lblpagibig.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpagibig.Location = new Point(8, 305);
            lblpagibig.Name = "lblpagibig";
            lblpagibig.Size = new Size(151, 45);
            lblpagibig.TabIndex = 5;
            lblpagibig.Text = "Pag-IBIG";
            lblpagibig.Click += label2_Click;
            // 
            // lblpercent
            // 
            lblpercent.AutoSize = true;
            lblpercent.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpercent.Location = new Point(172, 84);
            lblpercent.Name = "lblpercent";
            lblpercent.Size = new Size(31, 30);
            lblpercent.TabIndex = 7;
            lblpercent.Text = "%";
            // 
            // lblpercentmid
            // 
            lblpercentmid.AutoSize = true;
            lblpercentmid.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpercentmid.Location = new Point(172, 241);
            lblpercentmid.Name = "lblpercentmid";
            lblpercentmid.Size = new Size(31, 30);
            lblpercentmid.TabIndex = 8;
            lblpercentmid.Text = "%";
            // 
            // lblpercentbottom
            // 
            lblpercentbottom.AutoSize = true;
            lblpercentbottom.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpercentbottom.Location = new Point(172, 375);
            lblpercentbottom.Name = "lblpercentbottom";
            lblpercentbottom.Size = new Size(31, 30);
            lblpercentbottom.TabIndex = 9;
            lblpercentbottom.Text = "%";
            // 
            // btnsave
            // 
            btnsave.Location = new Point(735, 529);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(79, 34);
            btnsave.TabIndex = 2;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // btnback
            // 
            btnback.Location = new Point(652, 529);
            btnback.Name = "btnback";
            btnback.Size = new Size(77, 34);
            btnback.TabIndex = 3;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            // 
            // pbtop
            // 
            pbtop.Location = new Point(8, 65);
            pbtop.Name = "pbtop";
            pbtop.Size = new Size(158, 69);
            pbtop.TabIndex = 2;
            // 
            // pbmid
            // 
            pbmid.BackColor = SystemColors.ActiveCaptionText;
            pbmid.ForeColor = Color.Black;
            pbmid.Location = new Point(8, 219);
            pbmid.Name = "pbmid";
            pbmid.Size = new Size(158, 69);
            pbmid.TabIndex = 4;
            // 
            // pbbottom
            // 
            pbbottom.BackColor = SystemColors.ControlText;
            pbbottom.Location = new Point(8, 353);
            pbbottom.Name = "pbbottom";
            pbbottom.Size = new Size(158, 69);
            pbbottom.TabIndex = 6;
            // 
            // DataUpdates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1184, 651);
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(pnl);
            Controls.Add(lbldataupdates);
            Name = "DataUpdates";
            Text = "DataUpdates";
            Load += DataUpdates_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label8;
        private PictureBox logo;
        private Panel pnl;
        private Label lbldataupdates;
        private Label lblsss;
        private Label lblphilhealth;
        private Label lblpagibig;
        private Label lblpercentbottom;
        private Label lblpercentmid;
        private Label lblpercent;
        private Button button1;
        private Button btnsave;
        private Button btnback;
        private ProgressBar pbbottom;
        private ProgressBar pbmid;
        private ProgressBar pbtop;
    }
}