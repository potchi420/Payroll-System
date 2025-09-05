using System.Drawing.Drawing2D;

namespace Payroll_System
{
    public class GradientPanel : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }

        public GradientPanel()
        {
            this.Resize += GradientPanel_Resize;
        }

        private void GradientPanel_Resize(object? sender, EventArgs e)
        {
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(
                this.ClientRectangle, 
                this.gradientTop, 
                this.gradientBottom, 
                90F
                );

            Graphics g = e.Graphics;
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}