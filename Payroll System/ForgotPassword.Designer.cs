namespace Payroll_System
{
    partial class ForgotPassword
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
            label1 = new Label();
            back = new LinkLabel();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtCode = new TextBox();
            send_code_btn = new Button();
            verify_btn = new Button();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 49);
            label1.Name = "label1";
            label1.Size = new Size(256, 36);
            label1.TabIndex = 0;
            label1.Text = "Forgot Password";
            // 
            // back
            // 
            back.AutoSize = true;
            back.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            back.LinkColor = SystemColors.Highlight;
            back.Location = new Point(191, 286);
            back.Name = "back";
            back.Size = new Size(96, 17);
            back.TabIndex = 9;
            back.TabStop = true;
            back.Text = "Back to Login";
            back.LinkClicked += back_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 105);
            label2.Name = "label2";
            label2.Size = new Size(350, 19);
            label2.TabIndex = 2;
            label2.Text = "Enter your registered email to verify your account";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(94, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(221, 25);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(94, 146);
            label3.Name = "label3";
            label3.Size = new Size(84, 16);
            label3.TabIndex = 5;
            label3.Text = "Email Adress";
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCode.Location = new Point(94, 222);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(221, 25);
            txtCode.TabIndex = 6;
            // 
            // send_code_btn
            // 
            send_code_btn.BackColor = Color.FromArgb(33, 145, 245);
            send_code_btn.FlatStyle = FlatStyle.Flat;
            send_code_btn.Font = new Font("Arial", 9.75F);
            send_code_btn.ForeColor = SystemColors.ControlLightLight;
            send_code_btn.Location = new Point(313, 165);
            send_code_btn.Name = "send_code_btn";
            send_code_btn.Size = new Size(82, 25);
            send_code_btn.TabIndex = 7;
            send_code_btn.Text = "Send-Code";
            send_code_btn.UseVisualStyleBackColor = false;
            send_code_btn.Click += send_code_btn_Click;
            // 
            // verify_btn
            // 
            verify_btn.BackColor = SystemColors.ControlDarkDark;
            verify_btn.FlatStyle = FlatStyle.Flat;
            verify_btn.Font = new Font("Arial", 9.75F);
            verify_btn.ForeColor = SystemColors.ControlLightLight;
            verify_btn.Location = new Point(313, 222);
            verify_btn.Name = "verify_btn";
            verify_btn.Size = new Size(82, 25);
            verify_btn.TabIndex = 8;
            verify_btn.Text = "Verify";
            verify_btn.UseVisualStyleBackColor = false;
            verify_btn.Click += verify_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 203);
            label4.Name = "label4";
            label4.Size = new Size(139, 16);
            label4.TabIndex = 9;
            label4.Text = "Enter Verification Code";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(59, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 301);
            panel1.TabIndex = 10;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(label4);
            Controls.Add(verify_btn);
            Controls.Add(send_code_btn);
            Controls.Add(txtCode);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(back);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel back;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtCode;
        private Button send_code_btn;
        private Button verify_btn;
        private Label label4;
        private Panel panel1;
    }
}