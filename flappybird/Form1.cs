using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappybird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;
            pipetop.Left -= pipespeed;
            pipebottom.Left -= pipespeed;
            scorelabel.Text = $"score: {score}";

            if(pipetop.Left < -100)
            {
                pipetop.Left = 200;
                score++;
            }
            if(pipebottom.Left < -100)
            {
                pipebottom.Left = 600;
                score++;
            }
            if(bird.Top < -25)
            {
                gameOver();
            }



            if(bird.Bounds.IntersectsWith(pipetop.Bounds) || bird.Bounds.IntersectsWith(pipebottom.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 5;
        }
        private void gameOver()
        {
           timer1.Stop();
            scorelabel.Text = $"Game Over!";
            playagain.Visible = true;
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Dispose(false);
        }
    }
}
