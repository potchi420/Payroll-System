using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_System
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();

            // Accent line for SSS panel
            Panel sssAccent = new Panel();
            sssAccent.Size = new Size(4, sss_panel.Height);
            sssAccent.Location = new Point(sss_panel.Left - 4, sss_panel.Top);
            sssAccent.BackColor = Color.SteelBlue;
            this.Controls.Add(sssAccent);
            sssAccent.BringToFront();

            // Accent line for PhilHealth panel
            // Accent line for PhilHealth panel – split into yellow and green
            int accentWidth = 4;
            int halfWidth = accentWidth / 2;

            // Yellow half
            Panel philhealthAccentYellow = new Panel();
            philhealthAccentYellow.Size = new Size(halfWidth, philhealth_panel.Height);
            philhealthAccentYellow.Location = new Point(philhealth_panel.Left - accentWidth, philhealth_panel.Top);
            philhealthAccentYellow.BackColor = Color.Gold;
            this.Controls.Add(philhealthAccentYellow);
            philhealthAccentYellow.BringToFront();

            // Green half
            Panel philhealthAccentGreen = new Panel();
            philhealthAccentGreen.Size = new Size(halfWidth, philhealth_panel.Height);
            philhealthAccentGreen.Location = new Point(philhealth_panel.Left - halfWidth, philhealth_panel.Top);
            philhealthAccentGreen.BackColor = Color.ForestGreen;
            this.Controls.Add(philhealthAccentGreen);
            philhealthAccentGreen.BringToFront();


            // Accent line for Pag-IBIG panel
            Panel pagibigAccent = new Panel();
            pagibigAccent.Size = new Size(4, pagibig_panel.Height);
            pagibigAccent.Location = new Point(pagibig_panel.Left - 4, pagibig_panel.Top);
            pagibigAccent.BackColor = Color.DarkBlue;
            this.Controls.Add(pagibigAccent);
            pagibigAccent.BringToFront();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
