using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(100, 100), new Size(30, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(130, 100), new Size(30, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(160, 100), new Size(30, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(190, 100), new Size(30, 10)));



            base.OnPaint(e);
        }
    }
}
