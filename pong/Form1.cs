using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        bool goup; //Boolean used to detect player up position 
        bool godown; //Boolean used to detect player down position
        int speed = 6;
        int ballx = 6; //Horizontal X speed value for the ball
        int bally = 6; //Vertical Y speed value for the ball
        int score = 0;
        int cpupoint = 0;
        SoundPlayer playerSound = new SoundPlayer(@".\player.wav");
        SoundPlayer computerSound = new SoundPlayer(@".\computer.wav");
        public Form1()
        {

            InitializeComponent();
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
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
        }

        private void timerTick(object sender, EventArgs e)
        {
            //Show player and Cpu score
            PlayerScore.Text = "" + score;
            CPUScore.Text = "" + cpupoint;

            ball.Top -= bally; //Assign the ball TOP to ball Y integer
            ball.Left -= ballx; //Assign the ball LEFT to ball X integer

            cpuMove();

            //If the ball has gone passed the player through the left
            if (ball.Left < 0)
            {
                ball.Left = 434; //Reset the ball to the middle of the screen
                ballx = -ballx; //Change the balls direction
                ballx -= 2; //Increase the speed
                cpupoint++; //Add 1 to the CPU score
            }

            //If the ball has gone passed the CPU through the right
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434; //Reset the ball to the middle of the screen
                ballx = -ballx; //Change the balls direction
                ballx += 2; //Increase the speed
                score++; //Add 1 to the players score
            }

            //Controlling the ball
            //If the ball either reaches the top of the screen or the bottom
            if(ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                //Reverse the speed of the ball so it stays within the screen
                bally = -bally;
            }

            //If the ball hits the player or the CPU
            if(ball.Bounds.IntersectsWith(Player1.Bounds))
            {
                //Then bounce the ball in the other direction
                ballx = -ballx;
                playerSound.Play();
            }

            if (ball.Bounds.IntersectsWith(CPU.Bounds))
            {
                ballx = -ballx;
                computerSound.Play();
            }

            //Controlling the player
            //If go up boolean is true and player is within the top boundary
            if(goup == true && Player1.Top > 0)
            {
                //Move player towards the top
                Player1.Top -= 8;
            }

            //If go down boolean is true and player is within the bottom boundary
            if(godown == true && Player1.Top < 455)
            {
                //Move the player towards the bottom
                Player1.Top += 8;
            }

            if(score > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("You win this game");
            }

            if(cpupoint > 10)
            {
                GameTimer.Stop();
                MessageBox.Show("CPU wins, try again");
            }
        }
        private void cpuMove()
        {
            if (CPU.Top < ball.Top - 30)
            {
                CPU.Top += speed;
            }
            else if (CPU.Top > ball.Top + 30)
            {
                CPU.Top -= speed;
            }
        }
    }
}
