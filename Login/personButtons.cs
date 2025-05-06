using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class personButtons : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            Rectangle newRect = new Rectangle(0, 0, this.Width, this.Height);
            path.AddArc(newRect.X, newRect.Y, radius, radius, 180, 90);
            path.AddArc(newRect.Right - radius, newRect.Y, radius, radius, 270, 90);
            path.AddArc(newRect.Right - radius, newRect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(newRect.X, newRect.Bottom - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            this.Region = new Region(path);
        }
    }
}
