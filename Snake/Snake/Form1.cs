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
            FieldBackground FieldBack = new FieldBackground();
            FieldBack.Location= new System.Drawing.Point(2, 96);
            FieldBack.Size = new Size(604, 604);
            this.Controls.Add(FieldBack);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(100, 100), new Size(30, 10)));
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(130, 100), new Size(30, 10)));
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(160, 100), new Size(30, 10)));
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(190, 100), new Size(30, 10)));
            //e.Graphics.FillRectangle(new SolidBrush(Color.YellowGreen), new Rectangle(new Point(2, 2), new Size(600, 600)));
            //e.Graphics.DrawRectangle(Pens.DarkGray, new Rectangle(new Point(0, 0), new Size(604, 604)));

            base.OnPaint(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Background_Click(object sender, EventArgs e)
        {

        }

        private void GameOverlabel_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
