namespace Payroll_System
{
    partial class Register
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
            gradientPanel3 = new GradientPanel();
            label6 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            login_btn = new Button();
            password = new TextBox();
            label5 = new Label();
            username = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel3
            // 
            gradientPanel3.Controls.Add(pictureBox2);
            gradientPanel3.Controls.Add(label6);
            gradientPanel3.Controls.Add(label4);
            gradientPanel3.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel3.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel3.Location = new Point(1, 2);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(583, 616);
            gradientPanel3.TabIndex = 8;
            gradientPanel3.Paint += gradientPanel3_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(116, 314);
            label6.Name = "label6";
            label6.Size = new Size(298, 31);
            label6.TabIndex = 9;
            label6.Text = "Join our university now.";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(84, 259);
            label4.Name = "label4";
            label4.Size = new Size(356, 55);
            label4.TabIndex = 8;
            label4.Text = "Create Account";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.clouds_upright_2x;
            pictureBox2.Location = new Point(446, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 645);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(674, 229);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // login_btn
            // 
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(741, 416);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 27);
            login_btn.TabIndex = 14;
            login_btn.Text = "Register";
            login_btn.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.Location = new Point(674, 250);
            password.Name = "password";
            password.Size = new Size(197, 23);
            password.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(676, 348);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // username
            // 
            username.Location = new Point(676, 307);
            username.Name = "username";
            username.Size = new Size(197, 23);
            username.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(674, 286);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 15;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(674, 369);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 16;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1014, 611);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(login_btn);
            Controls.Add(password);
            Controls.Add(label5);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(gradientPanel3);
            Name = "Register";
            Text = "Register";
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel3;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Button login_btn;
        private TextBox password;
        private Label label5;
        private TextBox username;
        private Label label2;
        private TextBox textBox1;
    }
}