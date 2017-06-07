using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruchtGenerierungTest
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        int alarmCounter = 0;
        //int varPointX = 100;
        //int varPointY = 100;
        //Erdbeere Erdbeere1 = new Erdbeere();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
                 myTimer.Stop();

            
            alarmCounter += 1;


            //// Displays a message box asking whether to continue running the timer.
            //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Restarts the timer and increments the counter.
            //    myTimer.Start();
            //}

            //varPointX = varPointX - 10;

            Invalidate();

            //if (alarmCounter >= 4)
            //{
            //    varPointY = varPointY - 10;

            //    if (alarmCounter >= 5)
            //    {
            //        varPointX = varPointX + 10;
            //    }

            //    if (alarmCounter >= 6)
            //    {
            //        varPointY = varPointY + 10;
            //        varPointX = varPointX + 10;
            //    }

            //    if (alarmCounter >= 11)
            //    {
            //        varPointY = varPointY + 10;
            //        varPointX = varPointX - 10;
            //    }


            //    if (alarmCounter >= 13)
            //    {
            //        varPointY = varPointY - 10;
            //        varPointX = varPointX - 10;
            //        myTimer.Stop();
            //    }
         //   }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { }

        protected override void OnPaint(PaintEventArgs e)
        {
            ZeichneErdbeere(e);

            base.OnPaint(e);
        }

        private static void ZeichneErdbeere(PaintEventArgs e)
        {
            Random rnd = new Random();
            int zufallX = rnd.Next(50, 600);
            int zufallY = rnd.Next(50, 600);

            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(370, 175), new Size(5, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(410, 175), new Size(5, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(380, 150), new Size(25, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(375, 155), new Size(35, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(370, 165), new Size(45, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(375, 175), new Size(35, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(375, 180), new Size(35, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(380, 185), new Size(25, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(385, 190), new Size(15, 10)));
            //     e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(390, 200), new Size(5, 5)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(385, 180), new Size(5, 5)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(395, 180), new Size(5, 5)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(385, 180), new Size(5, 5)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), new Rectangle(new Point(390, 190), new Size(5, 5)));
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            myTimer.Start();
        }
    }
}