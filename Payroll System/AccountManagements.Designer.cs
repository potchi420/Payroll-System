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
            new_password_value = new TextBox();
            label1 = new Label();
            btnback = new Button();
            btnsave = new Button();
            cur_password_value = new TextBox();
            lblpassword = new Label();
            new_username_value = new TextBox();
            lblnew = new Label();
            lblcurrent = new Label();
            cur_username_value = new TextBox();
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
            pnlmain.Controls.Add(new_password_value);
            pnlmain.Controls.Add(label1);
            pnlmain.Controls.Add(btnback);
            pnlmain.Controls.Add(btnsave);
            pnlmain.Controls.Add(cur_password_value);
            pnlmain.Controls.Add(lblpassword);
            pnlmain.Controls.Add(new_username_value);
            pnlmain.Controls.Add(lblnew);
            pnlmain.Controls.Add(lblcurrent);
            pnlmain.Controls.Add(cur_username_value);
            pnlmain.Controls.Add(lblheader);
            pnlmain.Location = new Point(420, 108);
            pnlmain.Name = "pnlmain";
            pnlmain.Size = new Size(350, 470);
            pnlmain.TabIndex = 0;
            // 
            // new_password_value
            // 
            new_password_value.Location = new Point(16, 377);
            new_password_value.Name = "new_password_value";
            new_password_value.Size = new Size(315, 23);
            new_password_value.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 341);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 9;
            label1.Text = "New Password";
            // 
            // btnback
            // 
            btnback.BackColor = Color.White;
            btnback.Cursor = Cursors.Hand;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.ForeColor = SystemColors.Highlight;
            btnback.Location = new Point(14, 421);
            btnback.Name = "btnback";
            btnback.Size = new Size(142, 29);
            btnback.TabIndex = 8;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatStyle = FlatStyle.Popup;
            btnsave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(189, 421);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(142, 29);
            btnsave.TabIndex = 7;
            btnsave.Text = "Save Changes";
            btnsave.UseVisualStyleBackColor = false;
            // 
            // cur_password_value
            // 
            cur_password_value.Location = new Point(15, 296);
            cur_password_value.Name = "cur_password_value";
            cur_password_value.Size = new Size(317, 23);
            cur_password_value.TabIndex = 6;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpassword.Location = new Point(16, 260);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(148, 19);
            lblpassword.TabIndex = 5;
            lblpassword.Text = "Current Password";
            // 
            // new_username_value
            // 
            new_username_value.Location = new Point(16, 213);
            new_username_value.Name = "new_username_value";
            new_username_value.Size = new Size(316, 23);
            new_username_value.TabIndex = 4;
            // 
            // lblnew
            // 
            lblnew.AutoSize = true;
            lblnew.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnew.Location = new Point(16, 177);
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
            lblcurrent.Location = new Point(15, 95);
            lblcurrent.Name = "lblcurrent";
            lblcurrent.Size = new Size(149, 19);
            lblcurrent.TabIndex = 2;
            lblcurrent.Text = "Current Username";
            lblcurrent.Click += lblcurrent_Click;
            // 
            // cur_username_value
            // 
            cur_username_value.Location = new Point(16, 126);
            cur_username_value.Name = "cur_username_value";
            cur_username_value.Size = new Size(316, 23);
            cur_username_value.TabIndex = 1;
            cur_username_value.TextChanged += textBox1_TextChanged;
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
        private TextBox cur_username_value;
        private Label lblheader;
        private TextBox new_username_value;
        private Label lblnew;
        private Button btnsave;
        private TextBox cur_password_value;
        private Label lblpassword;
        private Button btnback;
        private Label home_btn;
        private Label logout_btn;
        private Label label6;
        private PictureBox logo_btn;
        private TextBox new_password_value;
        private Label label1;
    }
}