namespace Payroll_System
{
    partial class EmailVerification
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmailVerification));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            verifybtn = new Button();
            label1 = new Label();
            label2 = new Label();
            resendbtn = new Button();
            timerOTP = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(67, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(33, 26);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(106, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(33, 26);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(145, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(33, 26);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(184, 123);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(33, 26);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(223, 123);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(33, 26);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(262, 123);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(33, 26);
            textBox6.TabIndex = 6;
            // 
            // verifybtn
            // 
            verifybtn.BackColor = SystemColors.Highlight;
            verifybtn.Cursor = Cursors.Hand;
            verifybtn.FlatStyle = FlatStyle.Flat;
            verifybtn.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            verifybtn.ForeColor = SystemColors.ButtonHighlight;
            verifybtn.Location = new Point(184, 190);
            verifybtn.Name = "verifybtn";
            verifybtn.Size = new Size(111, 33);
            verifybtn.TabIndex = 7;
            verifybtn.Text = "Verify";
            verifybtn.UseVisualStyleBackColor = false;
            verifybtn.Click += verifybtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 65);
            label1.Name = "label1";
            label1.Size = new Size(198, 18);
            label1.TabIndex = 8;
            label1.Text = "Enter the 6-digit code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 92);
            label2.Name = "label2";
            label2.Size = new Size(121, 14);
            label2.TabIndex = 9;
            label2.Text = "sent to your email";
            // 
            // resendbtn
            // 
            resendbtn.BackColor = Color.White;
            resendbtn.Cursor = Cursors.Hand;
            resendbtn.FlatStyle = FlatStyle.Popup;
            resendbtn.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resendbtn.ForeColor = SystemColors.Highlight;
            resendbtn.Location = new Point(67, 190);
            resendbtn.Name = "resendbtn";
            resendbtn.Size = new Size(111, 33);
            resendbtn.TabIndex = 10;
            resendbtn.Text = "Resend Code";
            resendbtn.UseVisualStyleBackColor = false;
            resendbtn.Click += resendbtn_Click;
            // 
            // timerOTP
            // 
            timerOTP.Interval = 1000;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(113, 162);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(134, 13);
            lblTimer.TabIndex = 11;
            lblTimer.Text = "Code Expires in 02:00";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(158, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 39);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // EmailVerification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 305);
            Controls.Add(pictureBox1);
            Controls.Add(lblTimer);
            Controls.Add(resendbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(verifybtn);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EmailVerification";
            Text = "EmailVerification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button verifybtn;
        private Label label1;
        private Label label2;
        private Button resendbtn;
        private System.Windows.Forms.Timer timerOTP;
        private Label lblTimer;
        private PictureBox pictureBox1;
    }
}