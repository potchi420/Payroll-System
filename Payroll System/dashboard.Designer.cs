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
            pnltop = new Panel();
            lblsystem = new Label();
            pnlside = new Panel();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btnemployeeside = new Button();
            btnhome = new Button();
            pnlcenter = new Panel();
            btnsettings = new Button();
            btnbenefits = new Button();
            btntax = new Button();
            btnreportscenter = new Button();
            btnpayrollcenter = new Button();
            btnemployeecenter = new Button();
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
            // lblsystem
            // 
            lblsystem.AutoSize = true;
            lblsystem.Location = new Point(721, 29);
            lblsystem.Name = "lblsystem";
            lblsystem.Size = new Size(110, 15);
            lblsystem.TabIndex = 0;
            lblsystem.Text = "PCU Payroll System";
            lblsystem.TextAlign = ContentAlignment.MiddleCenter;
            lblsystem.Click += lblsystem_Click_1;
            // 
            // pnlside
            // 
            pnlside.BackColor = SystemColors.GradientInactiveCaption;
            pnlside.Controls.Add(button7);
            pnlside.Controls.Add(button6);
            pnlside.Controls.Add(button5);
            pnlside.Controls.Add(button4);
            pnlside.Controls.Add(button3);
            pnlside.Controls.Add(button2);
            pnlside.Controls.Add(button1);
            pnlside.Controls.Add(btnemployeeside);
            pnlside.Controls.Add(btnhome);
            pnlside.Location = new Point(9, 108);
            pnlside.Name = "pnlside";
            pnlside.Size = new Size(170, 539);
            pnlside.TabIndex = 2;
            pnlside.Paint += pnlside_Paint;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.Control;
            button7.ForeColor = SystemColors.InfoText;
            button7.Location = new Point(0, 400);
            button7.Name = "button7";
            button7.Size = new Size(170, 36);
            button7.TabIndex = 8;
            button7.Text = "Log Out";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.Control;
            button6.ForeColor = SystemColors.InfoText;
            button6.Location = new Point(0, 350);
            button6.Name = "button6";
            button6.Size = new Size(170, 36);
            button6.TabIndex = 7;
            button6.Text = "Change Password";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Control;
            button5.ForeColor = SystemColors.InfoText;
            button5.Location = new Point(0, 301);
            button5.Name = "button5";
            button5.Size = new Size(170, 36);
            button5.TabIndex = 6;
            button5.Text = "Early Report";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Control;
            button4.ForeColor = SystemColors.InfoText;
            button4.Location = new Point(0, 254);
            button4.Name = "button4";
            button4.Size = new Size(170, 36);
            button4.TabIndex = 5;
            button4.Text = "Monthly Report";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Control;
            button3.ForeColor = SystemColors.InfoText;
            button3.Location = new Point(0, 208);
            button3.Name = "button3";
            button3.Size = new Size(170, 36);
            button3.TabIndex = 4;
            button3.Text = "Salary Report";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.ForeColor = SystemColors.InfoText;
            button2.Location = new Point(0, 162);
            button2.Name = "button2";
            button2.Size = new Size(170, 36);
            button2.TabIndex = 3;
            button2.Text = "Employee Report";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.ForeColor = SystemColors.InfoText;
            button1.Location = new Point(0, 117);
            button1.Name = "button1";
            button1.Size = new Size(170, 36);
            button1.TabIndex = 2;
            button1.Text = "Add Employees";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnemployeeside
            // 
            btnemployeeside.BackColor = SystemColors.Control;
            btnemployeeside.ForeColor = SystemColors.InfoText;
            btnemployeeside.Location = new Point(0, 73);
            btnemployeeside.Name = "btnemployeeside";
            btnemployeeside.Size = new Size(170, 36);
            btnemployeeside.TabIndex = 1;
            btnemployeeside.Text = "Add Category";
            btnemployeeside.UseVisualStyleBackColor = false;
            btnemployeeside.Click += btnemployeeside_Click;
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
            // btnsettings
            // 
            btnsettings.BackColor = SystemColors.ButtonFace;
            btnsettings.Image = (Image)resources.GetObject("btnsettings.Image");
            btnsettings.Location = new Point(907, 264);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(218, 209);
            btnsettings.TabIndex = 5;
            btnsettings.Text = "Settings\r\n\r\n";
            btnsettings.TextAlign = ContentAlignment.BottomCenter;
            btnsettings.UseVisualStyleBackColor = false;
            // 
            // btnbenefits
            // 
            btnbenefits.BackColor = SystemColors.ButtonFace;
            btnbenefits.Image = (Image)resources.GetObject("btnbenefits.Image");
            btnbenefits.Location = new Point(496, 264);
            btnbenefits.Name = "btnbenefits";
            btnbenefits.Size = new Size(218, 209);
            btnbenefits.TabIndex = 4;
            btnbenefits.Text = "Benefits\r\nAdministration\r\n\r\n";
            btnbenefits.TextAlign = ContentAlignment.BottomCenter;
            btnbenefits.UseVisualStyleBackColor = false;
            // 
            // btntax
            // 
            btntax.BackColor = SystemColors.ButtonFace;
            btntax.Image = (Image)resources.GetObject("btntax.Image");
            btntax.Location = new Point(91, 264);
            btntax.Name = "btntax";
            btntax.Size = new Size(218, 209);
            btntax.TabIndex = 3;
            btntax.Text = "Tax Filings\r\n\r\n";
            btntax.TextAlign = ContentAlignment.BottomCenter;
            btntax.UseVisualStyleBackColor = false;
            // 
            // btnreportscenter
            // 
            btnreportscenter.BackColor = SystemColors.ButtonFace;
            btnreportscenter.Image = (Image)resources.GetObject("btnreportscenter.Image");
            btnreportscenter.Location = new Point(907, 30);
            btnreportscenter.Name = "btnreportscenter";
            btnreportscenter.Size = new Size(218, 209);
            btnreportscenter.TabIndex = 2;
            btnreportscenter.Text = "Reports\r\n\r\n";
            btnreportscenter.TextAlign = ContentAlignment.BottomCenter;
            btnreportscenter.UseVisualStyleBackColor = false;
            // 
            // btnpayrollcenter
            // 
            btnpayrollcenter.BackColor = SystemColors.ButtonFace;
            btnpayrollcenter.Cursor = Cursors.Hand;
            btnpayrollcenter.Image = (Image)resources.GetObject("btnpayrollcenter.Image");
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
            btnemployeecenter.BackColor = SystemColors.ButtonFace;
            btnemployeecenter.Image = (Image)resources.GetObject("btnemployeecenter.Image");
            btnemployeecenter.Location = new Point(91, 30);
            btnemployeecenter.Name = "btnemployeecenter";
            btnemployeecenter.Size = new Size(218, 209);
            btnemployeecenter.TabIndex = 0;
            btnemployeecenter.Text = "Employee \r\nManagement\r\n\r\n";
            btnemployeecenter.TextAlign = ContentAlignment.BottomCenter;
            btnemployeecenter.UseVisualStyleBackColor = false;
            btnemployeecenter.Click += btnemployee_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 651);
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
        private Label lblsystem;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button7;
        private Button button6;
    }
}