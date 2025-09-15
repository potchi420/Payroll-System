﻿namespace Payroll_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label6 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            register_btn = new Button();
            register_username = new TextBox();
            label5 = new Label();
            register_password = new TextBox();
            pictureBox1 = new PictureBox();
            gradientPanel3 = new GradientPanel();
            label9 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            label3.Location = new Point(770, 284);
            label3.Name = "label3";
            label3.Size = new Size(99, 23);
            label3.TabIndex = 9;
            label3.Text = "Username";
            // 
            // register_btn
            // 
            register_btn.ForeColor = Color.Black;
            register_btn.Location = new Point(843, 484);
            register_btn.Margin = new Padding(3, 4, 3, 4);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(86, 35);
            register_btn.TabIndex = 14;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_Click;
            // 
            // register_username
            // 
            register_username.Location = new Point(770, 312);
            register_username.Margin = new Padding(3, 4, 3, 4);
            register_username.Name = "register_username";
            register_username.Size = new Size(225, 27);
            register_username.TabIndex = 13;
            register_username.TextChanged += register_username_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(773, 363);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 12;
            label5.Text = "Password";
            // 
            // register_password
            // 
            register_password.Location = new Point(770, 391);
            register_password.Margin = new Padding(3, 4, 3, 4);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(225, 27);
            register_password.TabIndex = 16;
            register_password.TextChanged += register_password_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.clouds_upright_2x;
            pictureBox1.Location = new Point(502, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 816);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Controls.Add(label9);
            gradientPanel3.Controls.Add(label7);
            gradientPanel3.Controls.Add(pictureBox1);
            gradientPanel3.Controls.Add(pictureBox3);
            gradientPanel3.gradientBottom = Color.FromArgb(33, 145, 245);
            gradientPanel3.gradientTop = Color.FromArgb(9, 74, 158);
            gradientPanel3.Location = new Point(0, -1);
            gradientPanel3.Margin = new Padding(3, 4, 3, 4);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(650, 819);
            gradientPanel3.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Calisto MT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(149, 491);
            label9.Name = "label9";
            label9.Size = new Size(279, 28);
            label9.TabIndex = 11;
            label9.Text = "Join Our University Now.";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Calisto MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(149, 181);
            label7.Name = "label7";
            label7.Size = new Size(271, 41);
            label7.TabIndex = 10;
            label7.Text = "Create Account";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(95, 207);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(349, 263);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Calisto MT", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(731, 191);
            label8.Name = "label8";
            label8.Size = new Size(353, 31);
            label8.TabIndex = 18;
            label8.Text = "PAYROLL MADE SIMPLE";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1159, 815);
            Controls.Add(label8);
            Controls.Add(gradientPanel3);
            Controls.Add(register_password);
            Controls.Add(register_btn);
            Controls.Add(register_username);
            Controls.Add(label5);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GradientPanel gradientPanel3;
        private Label label6;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Button register_btn;
        private TextBox register_username;
        private Label label5;
        private TextBox register_password;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
    }
}