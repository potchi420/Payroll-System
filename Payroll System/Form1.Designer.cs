namespace Payroll_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            menubutton = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.Highlight;
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(button2);
            sidebar.Controls.Add(button3);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(245, 578);
            sidebar.MinimumSize = new Size(70, 678);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(245, 678);
            sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(menubutton);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 92);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(52, 40);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "    Menu";
            // 
            // menubutton
            // 
            menubutton.Image = (Image)resources.GetObject("menubutton.Image");
            menubutton.Location = new Point(17, 34);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(26, 27);
            menubutton.SizeMode = PictureBoxSizeMode.CenterImage;
            menubutton.TabIndex = 0;
            menubutton.TabStop = false;
            menubutton.Click += menubutton_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(224, 224, 224);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 101);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(254, 61);
            button2.TabIndex = 2;
            button2.Text = "           Home";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(224, 224, 224);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 168);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(254, 61);
            button3.TabIndex = 3;
            button3.Text = "           Settings";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.FromArgb(224, 224, 224);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 235);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(254, 61);
            button4.TabIndex = 4;
            button4.Text = "           Help";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.FromArgb(224, 224, 224);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 302);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(254, 61);
            button5.TabIndex = 5;
            button5.Text = "           About";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += sidebarTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(982, 519);
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menubutton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private PictureBox menubutton;
        private System.Windows.Forms.Timer sidebartimer;
    }
}