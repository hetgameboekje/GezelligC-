using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcman_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        private void resetGame()
        {

        }
        private void gameOver(string message)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                if (!pictureBox5.Bounds.IntersectsWith(pictureBox9.Bounds))
                {
                    pictureBox9.Visible = false;
                    //They have collided
                }
                else if (!pictureBox5.Bounds.IntersectsWith(pictureBox10.Bounds))
                {
                    pictureBox10.Visible = false;
                    //They have collided
                }
                else
                {
                    
                }
                pictureBox5.Left -= -5;
            }
            if (e.KeyCode == Keys.A)
            {
                pictureBox5.Left -= 5;
            }
            if (e.KeyCode == Keys.W)
            {
                if (!pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    pictureBox5.Top -= 5;
                    //They have collided
                }
                else
                {
                    pictureBox5.Top -= -5;
                }
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox5.Top -= -5;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void keyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            button1.Visible = false;
        }
        private void CheckCollision()
        {
            if (pictureBox5.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                pictureBox1.Visible = false;
            }
        }



    }
}
