using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class FieldBackground : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen( Color.DarkGray, 4), new Rectangle(new Point(0, 0), new Size(604, 604)));

            base.OnPaint(e);
        }
    }
}
