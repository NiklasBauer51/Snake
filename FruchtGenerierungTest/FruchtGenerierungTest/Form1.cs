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
        Erdbeere erdbeere;

        public Form1()
        {
            InitializeComponent();
            erdbeere = new Erdbeere(new Point(1, 1));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 100;
                       // Invalidate();
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
                 myTimer.Stop();
            
            alarmCounter += 1;          
        //    Erdbeere1.ZeichneErdbeere(e);  
                                                     Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        { }

        protected override void OnPaint(PaintEventArgs e)
        {
            erdbeere.ZeichneErdbeere(e);

            base.OnPaint(e);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            myTimer.Start();
        }
    }
}