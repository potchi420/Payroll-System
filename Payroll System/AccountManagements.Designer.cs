namespace Payroll_System
{
    partial class AccountManagements
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
            label5 = new Label();
            logo = new PictureBox();
            pnlmain = new Panel();
            btnclear = new Button();
            btnsave = new Button();
            textBox3 = new TextBox();
            lblpassword = new Label();
            textBox2 = new TextBox();
            lblnew = new Label();
            lblcurrent = new Label();
            textBox1 = new TextBox();
            lblheader = new Label();
            gradientPanel1 = new GradientPanel();
            home_btn = new Label();
            logout_btn = new Label();
            label6 = new Label();
            logo_btn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlmain.SuspendLayout();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).BeginInit();
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
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            // 
            // pnlmain
            // 
            pnlmain.BorderStyle = BorderStyle.FixedSingle;
            pnlmain.Controls.Add(btnclear);
            pnlmain.Controls.Add(btnsave);
            pnlmain.Controls.Add(textBox3);
            pnlmain.Controls.Add(lblpassword);
            pnlmain.Controls.Add(textBox2);
            pnlmain.Controls.Add(lblnew);
            pnlmain.Controls.Add(lblcurrent);
            pnlmain.Controls.Add(textBox1);
            pnlmain.Controls.Add(lblheader);
            pnlmain.Location = new Point(420, 141);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(350, 437);
            pnlmain.TabIndex = 0;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.White;
            btnclear.FlatStyle = FlatStyle.Popup;
            btnclear.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclear.ForeColor = SystemColors.Highlight;
            btnclear.Location = new Point(190, 369);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(142, 29);
            btnclear.TabIndex = 8;
            btnclear.Text = "Clear Fields";
            btnclear.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(16, 369);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(142, 29);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save Changes";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(15, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 23);
            textBox3.TabIndex = 6;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(16, 273);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(148, 19);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Current Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(15, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 23);
            textBox2.TabIndex = 4;
            // 
            // lblnew
            // 
            lblnew.AutoSize = true;
            lblnew.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnew.Location = new Point(16, 190);
            lblnew.Name = "lblnew";
            lblnew.Size = new Size(125, 19);
            lblnew.TabIndex = 3;
            lblnew.Text = "New Username";
            lblnew.Click += lblnew_Click;
            // 
            // lblcurrent
            // 
            lblcurrent.AutoSize = true;
            lblcurrent.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcurrent.Location = new Point(15, 108);
            lblcurrent.Name = "lblcurrent";
            lblcurrent.Size = new Size(149, 19);
            lblcurrent.TabIndex = 2;
            lblcurrent.Text = "Current Username";
            lblcurrent.Click += lblcurrent_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblheader
            // 
            lblheader.AutoSize = true;
            lblheader.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblheader.Location = new Point(15, 27);
            lblheader.Name = "lblheader";
            lblheader.Size = new Size(317, 34);
            lblheader.TabIndex = 0;
            lblheader.Text = "Account Management";
            // 
            // gradientPanel1
            // 
            gradientPanel1.Controls.Add(home_btn);
            gradientPanel1.Controls.Add(logout_btn);
            gradientPanel1.Controls.Add(label6);
            gradientPanel1.Controls.Add(logo_btn);
            gradientPanel1.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel1.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel1.Location = new Point(-3, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1191, 76);
            gradientPanel1.TabIndex = 32;
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
            // AccountManagements
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 651);
            Controls.Add(gradientPanel1);
            Controls.Add(pnlmain);
            Name = "AccountManagements";
            Text = "AccountManagements";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlmain.ResumeLayout(false);
            pnlmain.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo_btn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label home;
        private Label logout;
        private Label label5;
        private PictureBox logo;
        private Panel pnlmain;
        private Label lblcurrent;
        private TextBox textBox1;
        private Label lblheader;
        private TextBox textBox2;
        private Label lblnew;
        private Button btnsave;
        private TextBox textBox3;
        private Label lblpassword;
        private Button btnclear;
        private Label home_btn;
        private Label logout_btn;
        private Label label6;
        private PictureBox logo_btn;
    }
}