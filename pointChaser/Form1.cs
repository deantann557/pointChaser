using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace pointChaser
{

    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(180, 170, 30, 30);
        Rectangle player2 = new Rectangle(240, 170, 30, 30);
        Rectangle Wall = new Rectangle( 10, 100, 580, 360);
        Rectangle ball = new Rectangle(495, 195, 10, 10);
        Rectangle speedBall = new Rectangle(300, 300, 10, 10);

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush beigeBrush = new SolidBrush(Color.Beige);
        SolidBrush pinkBrush = new SolidBrush(Color.Pink);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        Pen blackPen = new Pen(Color.Black, 15);

        int player1Speed = 6;
        int player2Speed = 6;

        Random randGen = new Random();

        int player1Score = 0;
        int player2Score = 0;

        SoundPlayer planeDing = new SoundPlayer(Properties.Resources.Air_Plane_Ding_SoundBible_com_496729130);
        SoundPlayer victory = new SoundPlayer(Properties.Resources.Short_triumphal_fanfare_John_Stracke_815794903);

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            P1PointLabel.Text = $"Player 1: {player1Score}";
            P2PointLabel.Text = $"Player 2: {player2Score}";

            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(beigeBrush, player2);
            e.Graphics.DrawRectangle(blackPen, 10, 100, 580, 360);
            e.Graphics.FillEllipse(pinkBrush, ball);
            e.Graphics.FillEllipse(yellowBrush, speedBall);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }

        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }


        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (player1.IntersectsWith(ball))
            {
                ball.X = randGen.Next(18, 574);
                ball.Y = randGen.Next(108, 443);
                player1Score++;
                planeDing.Play();
            }
            if (player2.IntersectsWith(ball))
            {
                ball.X = randGen.Next(18, 574);
                ball.Y = randGen.Next(108, 443);
                player2Score++;
                planeDing.Play();
            }
            if (player1.IntersectsWith(speedBall))
            {
                speedBall.X = randGen.Next(18, 574);
                speedBall.Y = randGen.Next(108, 443);
                player1Speed++;
                planeDing.Play();
            }
            if (player2.IntersectsWith(speedBall))
            {
                speedBall.X = randGen.Next(18, 574);
                speedBall.Y = randGen.Next(108, 443);
                player2Speed++;
                planeDing.Play();
            }

            //move player 1
            if (wDown == true && player1.Y > 108)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < 423)
            {
                player1.Y += player1Speed;
            }

            if (aDown == true && player1.X > 19)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < 550)
            {
                player1.X += player1Speed;
            }
            //move player 2
            if (upArrowDown == true && player2.Y > 108)
            {
                player2.Y -= player2Speed;
            }
            if (downArrowDown == true && player2.Y < 423)
            {
                player2.Y += player2Speed;
            }
            if (leftArrowDown == true && player2.X > 19)
            {
                player2.X -= player2Speed;
            }

            if (rightArrowDown == true && player2.X <550 )
            {
                player2.X += player2Speed;
            }


            //player1Score++;

            //
            //player2Score++;

            //// check score and stop game if either player is at 3
            if (player1Score == 5)
            {
                gameTimer.Enabled = false;
                VictoryLabel.Visible = true;
                VictoryLabel.Text = "Player 1 Wins!!";
                victory.Play();
            }
            else if (player2Score == 5)
            {
                gameTimer.Enabled = false;
                VictoryLabel.Visible = true;
                VictoryLabel.Text = "Player 2 Wins!!";
                victory.Play();
            }



            Refresh();
        }
    }
    }

