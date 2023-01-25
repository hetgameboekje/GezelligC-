using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_Man_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, redGhostSpeed, yellowGhostSpeed, pinkGhostX, pinkGhostY;

        private void pictureBox58_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

        }

        private void redGhost_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();

            resetGame();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if(e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if(e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if(e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                resetGame();
            }

        }

        private void mainGameTimer(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;

            if(goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;
            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if (pacman.Left > 680)
            {
                pacman.Left = -10;
            }

            if(pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if(pacman.Top > 550)
            {
                pacman.Top = 0;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }

                    if((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }


                        if(pinkGhost.Bounds.IntersectsWith(x.Bounds))
                        {
                            pinkGhostX = -pinkGhostX;
                        }
                    }


                    if((string)x.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            gameOver("You Lose!");
                        }

                    }
                }
            }


            // moving ghosts

            redGhost.Left += redGhostSpeed;

            if (redGhost.Bounds.IntersectsWith(pictureBox61.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox57.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }


            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(pictureBox63.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox67.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }


            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;


            if(pinkGhost.Top < 0 || pinkGhost.Top > 300)
            {
                pinkGhostY = -pinkGhostY;
            }

            if(pinkGhost.Left < 0 || pinkGhost.Left > 300)
            {
                pinkGhostX = -pinkGhostX;
            }




            if (score == 46)
            {
                gameOver("You Win!");
            }


        }

        private void resetGame()
        {

            txtScore.Text = "Score: 0";
            score = 0;

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhostX = 5;
            pinkGhostY = 5;
            playerSpeed = 8;

            isGameOver = false;

            pacman.Left = 31;
            pacman.Top = 46;
            // 102, 27
            redGhost.Left = 100;
            redGhost.Top = 25;
            //166, 500
            yellowGhost.Left = 500;
            yellowGhost.Top = 410;
            // 437, 298
            pinkGhost.Left = 440;
            pinkGhost.Top = 300;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                   x.Visible = true;
                }
            }


            gameTimer.Start();
        }

        private void gameOver(string message)
        {

            isGameOver = true;

            gameTimer.Stop();

            txtScore.Text = "Score: " + score + Environment.NewLine + message;

        }


    }
}
