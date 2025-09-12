namespace Payroll_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            login_btn = new Button();
            password = new TextBox();
            label5 = new Label();
            username = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            PCU = new Label();
            gradientPanel3 = new GradientPanel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(863, 386);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 27);
            login_btn.TabIndex = 6;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += button1_Click_1;
            // 
            // password
            // 
            password.Location = new Point(802, 335);
            password.Name = "password";
            password.Size = new Size(197, 23);
            password.TabIndex = 5;
            password.TextChanged += password_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(802, 305);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 4;
            label5.Text = "Password";
            // 
            // username
            // 
            username.Location = new Point(802, 260);
            username.Name = "username";
            username.Size = new Size(197, 23);
            username.TabIndex = 3;
            username.TextChanged += username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(802, 231);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // PCU
            // 
            PCU.Location = new Point(0, 0);
            PCU.Name = "PCU";
            PCU.Size = new Size(100, 23);
            PCU.TabIndex = 0;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Controls.Add(label7);
            gradientPanel3.Controls.Add(label6);
            gradientPanel3.Controls.Add(label4);
            gradientPanel3.Controls.Add(pictureBox2);
            gradientPanel3.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel3.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel3.Location = new Point(-2, -1);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(641, 646);
            gradientPanel3.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(123, 370);
            label7.Name = "label7";
            label7.Size = new Size(319, 55);
            label7.TabIndex = 10;
            label7.Text = "Payroll Sytem";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(218, 291);
            label6.Name = "label6";
            label6.Size = new Size(119, 37);
            label6.TabIndex = 9;
            label6.Text = "To The";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(165, 177);
            label4.Name = "label4";
            label4.Size = new Size(224, 55);
            label4.TabIndex = 8;
            label4.Text = "Welcome\r\n";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.clouds_upright_2x;
            pictureBox2.Location = new Point(503, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 645);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 688);
            Controls.Add(login_btn);
            Controls.Add(gradientPanel3);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button login_btn;
        private GradientPanel gradientPanel1;
        private Label PCU;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private GradientPanel gradientPanel2;
        private Label label5;
        private TextBox password;
        private Button login;
        private GradientPanel gradientPanel3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label7;
        private Label label6;
    }
}
