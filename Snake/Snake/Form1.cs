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
        Erdbeere erdbeere;

        public Form1()
        {
            InitializeComponent();
            erdbeere = new Erdbeere(new Point(1, 1));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            erdbeere.ZeichneErdbeere(e);    // Methode wird aufgerufen, um die Erdbeere zu zeichnen
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
    }
}
