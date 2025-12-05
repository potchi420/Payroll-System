namespace Payroll_System
{
    partial class ResetPassword
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
            label4 = new Label();
            reset_btn = new Button();
            label3 = new Label();
            confirmPass = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            newPass = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(128, 209);
            label4.Name = "label4";
            label4.Size = new Size(112, 16);
            label4.TabIndex = 19;
            label4.Text = "Confirm Password";
            // 
            // reset_btn
            // 
            reset_btn.BackColor = Color.FromArgb(33, 145, 245);
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.Font = new Font("Arial", 9.75F);
            reset_btn.ForeColor = SystemColors.ControlLightLight;
            reset_btn.Location = new Point(109, 238);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(150, 25);
            reset_btn.TabIndex = 17;
            reset_btn.Text = "Reset Password";
            reset_btn.UseVisualStyleBackColor = false;
            reset_btn.Click += reset_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 152);
            label3.Name = "label3";
            label3.Size = new Size(93, 16);
            label3.TabIndex = 15;
            label3.Text = "New Password";
            // 
            // confirmPass
            // 
            confirmPass.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPass.Location = new Point(78, 197);
            confirmPass.Name = "confirmPass";
            confirmPass.Size = new Size(221, 25);
            confirmPass.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 111);
            label2.Name = "label2";
            label2.Size = new Size(270, 19);
            label2.TabIndex = 13;
            label2.Text = "Please enter your new password below\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(121, 55);
            label1.Name = "label1";
            label1.Size = new Size(238, 36);
            label1.TabIndex = 11;
            label1.Text = "Reset Password";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(newPass);
            panel1.Controls.Add(reset_btn);
            panel1.Controls.Add(confirmPass);
            panel1.Location = new Point(53, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 305);
            panel1.TabIndex = 20;
            // 
            // newPass
            // 
            newPass.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newPass.Location = new Point(78, 139);
            newPass.Name = "newPass";
            newPass.Size = new Size(221, 25);
            newPass.TabIndex = 18;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "ResetPassword";
            Text = "ResetPassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button verify_btn;
        private Button reset_btn;
        private TextBox txtCode;
        private Label label3;
        private TextBox confirmPass;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private TextBox newPass;
    }
}