using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerSampleAufg
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        int alarmCounter = 0;
        int varPointX = 100;
        int varPointY = 100;


        public Form1()
        {
            InitializeComponent();
            //Random rnd = new Random();
            //int zufallX = rnd.Next(50, 100);
            //int zufallY = rnd.Next(50, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            myTimer = new Timer();
            /* Adds the event and the event handler for the method that will 
                   process the timer event to the timer. */
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 400;
        }

        // This is the method to run when the timer is raised.
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
       //     myTimer.Stop();


            alarmCounter += 1;

            //// Displays a message box asking whether to continue running the timer.
            //if (MessageBox.Show("Continue running?", "Count is: " + alarmCounter,
            //   MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    // Restarts the timer and increments the counter.
            //    myTimer.Start();
            //}

            varPointX = varPointX - 10;

            Invalidate();

            if (alarmCounter >= 4)
            {
                varPointY = varPointY - 10;

                if (alarmCounter >= 5)
                {
                    varPointX = varPointX + 10;
                }

                if (alarmCounter >= 6)
                {
                    varPointY = varPointY + 10;
                    varPointX = varPointX + 10;
                }

                if (alarmCounter >= 11)
                {
                    varPointY = varPointY + 10;
                    varPointX = varPointX - 10;
                }


                if (alarmCounter >= 13)
                {
                    //varPointY = varPointY - 10;
                    //varPointX = varPointX - 10;
                    myTimer.Stop();
                }
            }
        }

        private void buttonTimerStart_Click(object sender, EventArgs e)
        {
            myTimer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { 
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(new Point(varPointX, varPointY), new Size(10, 10)));
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(90, 90), new Size(5, 5)));
        }

    }
}
