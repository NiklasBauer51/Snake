using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snake
{
    class Erdbeere
    {
        public Point Position { get; set; }

        public Erdbeere(Point position)
        {
            Random rnd = new Random();          // Zufallsvariable X und Y im Bereich (50, 500)
            int zufallX = rnd.Next(50, 500);    
            int zufallY = rnd.Next(50, 500);

            position.X += zufallX; //Position.X = Position.X + zufallX, Parameter werden überwiesen
            position.Y += zufallY;
            Position = position;
        }

        public void ZeichneErdbeere(PaintEventArgs e)   // Erdbeere
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Position.X - 20, Position.Y + 5), new Size(5, 10))); // 370, 175
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Position.X + 20, Position.Y + 5), new Size(5, 10))); // 410, 175 
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Position.X - 10, Position.Y - 20), new Size(25, 10))); // 380, 150
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Position.X - 15, Position.Y - 15), new Size(35, 10))); // 375. 155
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Position.X - 20, Position.Y - 5), new Size(45, 10))); // 370, 165
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Position.X - 15, Position.Y + 5), new Size(35, 10))); // 375, 175
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Position.X - 15, Position.Y + 10), new Size(35, 10))); // 375, 180
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Position.X - 10, Position.Y + 15), new Size(25, 10))); // 380, 185
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Position.X - 5, Position.Y + 20), new Size(15, 10))); // 385, 190
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(Position.X - 5, Position.Y + 10), new Size(5, 5))); // 385, 180
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(Position.X + 5, Position.Y + 10), new Size(5, 5))); // 395, 180
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(Position.X - 5, Position.Y + 10), new Size(5, 5))); // 385, 180
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(Position.X, Position.Y + 20), new Size(5, 5))); // 390, 190
            //    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(new Point(390, 170), new Size(5, 5))); // Fixpunkt
        }
    }
}
