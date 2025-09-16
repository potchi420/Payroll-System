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
            pnltop = new Panel();
            pnlside = new Panel();
            btnhome = new Button();
            pnlcenter = new Panel();
            btnpayrollcenter = new Button();
            btnemployeecenter = new Button();
            btnreportscenter = new Button();
            btntax = new Button();
            btnbenefits = new Button();
            btnsettings = new Button();
            btnemployeeside = new Button();
            btnpayrollside = new Button();
            btnreportside = new Button();
            lblsystem = new Label();
            pnltop.SuspendLayout();
            pnlside.SuspendLayout();
            pnlcenter.SuspendLayout();
            SuspendLayout();
            // 
            // pnltop
            // 
            pnltop.BackColor = SystemColors.Highlight;
            pnltop.Controls.Add(lblsystem);
            pnltop.Location = new Point(12, 27);
            pnltop.Name = "pnltop";
            pnltop.Size = new Size(1405, 75);
            pnltop.TabIndex = 1;
            pnltop.Paint += panel2_Paint;
            // 
            // pnlside
            // 
            pnlside.BackColor = SystemColors.GradientInactiveCaption;
            pnlside.Controls.Add(btnreportside);
            pnlside.Controls.Add(btnpayrollside);
            pnlside.Controls.Add(btnemployeeside);
            pnlside.Controls.Add(btnhome);
            pnlside.Location = new Point(9, 108);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(170, 539);
            pnlside.TabIndex = 2;
            pnlside.Paint += pnlside_Paint;
            // 
            // btnhome
            // 
            btnhome.BackColor = SystemColors.Highlight;
            btnhome.ForeColor = SystemColors.Menu;
            btnhome.Location = new Point(0, 3);
            btnhome.Name = "btnhome";
            btnhome.Size = new Size(170, 64);
            btnhome.TabIndex = 0;
            btnhome.Text = "Home";
            btnhome.UseVisualStyleBackColor = false;
            // 
            // pnlcenter
            // 
            pnlcenter.BackColor = SystemColors.Highlight;
            pnlcenter.Controls.Add(btnsettings);
            pnlcenter.Controls.Add(btnbenefits);
            pnlcenter.Controls.Add(btntax);
            pnlcenter.Controls.Add(btnreportscenter);
            pnlcenter.Controls.Add(btnpayrollcenter);
            pnlcenter.Controls.Add(btnemployeecenter);
            pnlcenter.Location = new Point(185, 108);
            pnlcenter.Name = "pnlcenter";
            pnlcenter.Size = new Size(1232, 539);
            pnlcenter.TabIndex = 3;
            // 
            // btnpayrollcenter
            // 
            btnpayrollcenter.BackColor = SystemColors.ActiveCaption;
            btnpayrollcenter.Location = new Point(496, 30);
            btnpayrollcenter.Name = "btnpayrollcenter";
            btnpayrollcenter.Size = new Size(218, 209);
            btnpayrollcenter.TabIndex = 1;
            btnpayrollcenter.Text = "Payroll\r\nProcessing\r\n\r\n";
            btnpayrollcenter.TextAlign = ContentAlignment.BottomCenter;
            btnpayrollcenter.UseVisualStyleBackColor = false;
            btnpayrollcenter.Click += btnpayrollcenter_Click;
            // 
            // btnemployeecenter
            // 
            btnemployeecenter.BackColor = SystemColors.ActiveCaption;
            btnemployeecenter.Location = new Point(91, 30);
            btnemployeecenter.Name = "btnemployeecenter";
            btnemployeecenter.Size = new Size(218, 209);
            btnemployeecenter.TabIndex = 0;
            btnemployeecenter.Text = "Employee \r\nManagement\r\n\r\n";
            btnemployeecenter.TextAlign = ContentAlignment.BottomCenter;
            btnemployeecenter.UseVisualStyleBackColor = false;
            btnemployeecenter.Click += btnemployee_Click;
            // 
            // btnreportscenter
            // 
            btnreportscenter.BackColor = SystemColors.ActiveCaption;
            btnreportscenter.Location = new Point(907, 30);
            btnreportscenter.Name = "btnreportscenter";
            btnreportscenter.Size = new Size(218, 209);
            btnreportscenter.TabIndex = 2;
            btnreportscenter.Text = "Reports\r\n\r\n";
            btnreportscenter.TextAlign = ContentAlignment.BottomCenter;
            btnreportscenter.UseVisualStyleBackColor = false;
            // 
            // btntax
            // 
            btntax.BackColor = SystemColors.ActiveCaption;
            btntax.Location = new Point(91, 264);
            btntax.Name = "btntax";
            btntax.Size = new Size(218, 209);
            btntax.TabIndex = 3;
            btntax.Text = "Tax Filings\r\n\r\n";
            btntax.TextAlign = ContentAlignment.BottomCenter;
            btntax.UseVisualStyleBackColor = false;
            // 
            // btnbenefits
            // 
            btnbenefits.BackColor = SystemColors.ActiveCaption;
            btnbenefits.Location = new Point(496, 264);
            btnbenefits.Name = "btnbenefits";
            btnbenefits.Size = new Size(218, 209);
            btnbenefits.TabIndex = 4;
            btnbenefits.Text = "Benefits\r\nAdministration\r\n\r\n";
            btnbenefits.TextAlign = ContentAlignment.BottomCenter;
            btnbenefits.UseVisualStyleBackColor = false;
            // 
            // btnsettings
            // 
            btnsettings.BackColor = SystemColors.ActiveCaption;
            btnsettings.Location = new Point(907, 264);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(218, 209);
            btnsettings.TabIndex = 5;
            btnsettings.Text = "Settings\r\n\r\n";
            btnsettings.TextAlign = ContentAlignment.BottomCenter;
            btnsettings.UseVisualStyleBackColor = false;
            // 
            // btnemployeeside
            // 
            btnemployeeside.BackColor = SystemColors.Control;
            btnemployeeside.ForeColor = SystemColors.InfoText;
            btnemployeeside.Location = new Point(0, 73);
            btnemployeeside.Name = "btnemployeeside";
            btnemployeeside.Size = new Size(170, 50);
            btnemployeeside.TabIndex = 1;
            btnemployeeside.Text = "Employees";
            btnemployeeside.UseVisualStyleBackColor = false;
            // 
            // btnpayrollside
            // 
            btnpayrollside.BackColor = SystemColors.Control;
            btnpayrollside.ForeColor = SystemColors.InfoText;
            btnpayrollside.Location = new Point(0, 129);
            btnpayrollside.Name = "btnpayrollside";
            btnpayrollside.Size = new Size(170, 50);
            btnpayrollside.TabIndex = 2;
            btnpayrollside.Text = "Payroll";
            btnpayrollside.UseVisualStyleBackColor = false;
            btnpayrollside.Click += button1_Click;
            // 
            // btnreportside
            // 
            btnreportside.BackColor = SystemColors.Control;
            btnreportside.ForeColor = SystemColors.InfoText;
            btnreportside.Location = new Point(0, 185);
            btnreportside.Name = "btnreportside";
            btnreportside.Size = new Size(170, 54);
            btnreportside.TabIndex = 3;
            btnreportside.Text = "Reports";
            btnreportside.UseVisualStyleBackColor = false;
            btnreportside.Click += btnreportside_Click;
            // 
            // lblsystem
            // 
            lblsystem.AutoSize = true;
            lblsystem.Location = new Point(721, 29);
            lblsystem.Name = "lblsystem";
            lblsystem.Size = new Size(110, 15);
            lblsystem.TabIndex = 0;
            lblsystem.Text = "PCU Payroll System";
            lblsystem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1429, 651);
            Controls.Add(pnlcenter);
            Controls.Add(pnlside);
            Controls.Add(pnltop);
            Name = "dashboard";
            Text = "dashboard";
            pnltop.ResumeLayout(false);
            pnltop.PerformLayout();
            pnlside.ResumeLayout(false);
            pnlcenter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnltop;
        private Panel pnlside;
        private Button btnhome;
        private Panel pnlcenter;
        private Button btnpayrollcenter;
        private Button btnemployeecenter;
        private Button btnreportscenter;
        private Button btntax;
        private Button btnsettings;
        private Button btnbenefits;
        private Button btnemployeeside;
        private Button btnpayrollside;
        private Button btnreportside;
        private Label lblsystem;
    }
}