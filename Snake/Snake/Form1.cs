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
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            // Einstellungen auf Standard setzen
            new Einstellung();
            erdbeere = new Erdbeere(new Point(1, 1));
            // Spielgeschwindigkeit einstellen und Timer starten
            gameTimer.Interval = 900 / Einstellung.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //Neues Spiel starten
            StartGame();
        }
        private void StartGame()
        {
            GameOverlabel.Visible = false;

            // Einstellungen auf Standard setzen
            new Einstellung();

            // Neues Spielerobjekt erstellen
            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);


            ScoreLabel.Text = Einstellung.Score.ToString();
            GenerateFood();

        }
        private void GenerateFood()
        {
            int maxXPos = Background.Size.Width / Einstellung.Width;
            int maxYPos = Background.Size.Height / Einstellung.Height;

            Random random = new Random();
            food = new Circle {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            //Check für Game Over
            if (Einstellung.GameOver)
            {
                //Prüfen, ob Enter gedrückt wird
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Einstellung.direction != Direction.Left)
                    Einstellung.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Einstellung.direction != Direction.Right)
                    Einstellung.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Einstellung.direction != Direction.Down)
                    Einstellung.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Einstellung.direction != Direction.Up)
                    Einstellung.direction = Direction.Down;

                MovePlayer();
            }

            Background.Invalidate();

        }
        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //Kopf bewegen
                if (i == 0)
                {
                    switch (Einstellung.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }


                    // Maximales X und Y Pos erhalten
                    int maxXPos = Background.Size.Width / Einstellung.Width;
                    int maxYPos = Background.Size.Height / Einstellung.Height;

                    // Kollision mit Spielgrenzen erkennen.
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    // Kollision mit Körper erkennen
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    // Kollision mit Lebensmittelstück erkennen
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    //Körper bewegen
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }
        private void Die()
        {
            Einstellung.GameOver = true;
        }
        private void Eat()
        {
            // Circle zum Körper hinzufügen
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            //Update Score
            Einstellung.Score += Einstellung.Points;
            ScoreLabel.Text = Einstellung.Score.ToString();

            GenerateFood();
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

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
