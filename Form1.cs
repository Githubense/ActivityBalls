using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsDelTeacher
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics g;
        Ball ball;
        List<Ball> balls;
        SolidBrush brush;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp                 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g                   = Graphics.FromImage(bmp);
            pictureBox1.Image   = bmp;
            balls               = new List<Ball>();   

            for(int b=0; b<5; b++)
                balls.Add(new Ball(bmp.Size));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black);

            for(int b=1; b< (balls.Count); b++)
            {
                ball = balls[b];
                brush = new SolidBrush(ball.c);
                g.FillEllipse(brush, ball.p.X - ball.size, ball.p.Y - ball.size, ball.size, ball.size);

                // Check for collision
                double distance12 = Math.Sqrt((balls[1].p.X - balls[2].p.X) * (balls[1].p.X - balls[2].p.X) + (balls[1].p.Y- balls[2].p.Y) * (balls[1].p.Y - balls[2].p.Y));

                if (distance12 <= (balls[1].size/2) + (balls[2].size/2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[1].v.X;
                    float tempVy = balls[1].v.Y;
                    balls[1].v.X = balls[2].v.X;
                    balls[1].v.Y = balls[2].v.Y;
                    balls[2].v.X = tempVx;
                    balls[2].v.Y = tempVy;
                }

                double distance13 = Math.Sqrt((balls[1].p.X - balls[3].p.X) * (balls[1].p.X - balls[3].p.X) + (balls[1].p.Y - balls[3].p.Y) * (balls[1].p.Y - balls[3].p.Y));

                if (distance13 <= (balls[1].size / 2) + (balls[3].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[1].v.X;
                    float tempVy = balls[1].v.Y;
                    balls[1].v.X = balls[3].v.X;
                    balls[1].v.Y = balls[3].v.Y;
                    balls[3].v.X = tempVx;
                    balls[3].v.Y = tempVy;
                }


                //pelota1
                double distance14 = Math.Sqrt((balls[1].p.X - balls[4].p.X) * (balls[1].p.X - balls[4].p.X) + (balls[1].p.Y - balls[4].p.Y) * (balls[1].p.Y - balls[4].p.Y));

                if (distance14 <= (balls[1].size/2) + (balls[4].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[1].v.X;
                    float tempVy = balls[1].v.Y;
                    balls[1].v.X = balls[4].v.X;
                    balls[1].v.Y = balls[4].v.Y;
                    balls[4].v.X = tempVx;
                    balls[4].v.Y = tempVy;
                }

                /*
                double distance15 = Math.Sqrt((balls[1].p.X - balls[5].p.X) * (balls[1].p.X - balls[5].p.X) + (balls[1].p.Y - balls[5].p.Y) * (balls[1].p.Y - balls[5].p.Y));

                if (distance15 <= (balls[1].size / 2) + (balls[5].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[1].v.X;
                    float tempVy = balls[1].v.Y;
                    balls[1].v.X = balls[5].v.X;
                    balls[1].v.Y = balls[5].v.Y;
                    balls[5].v.X = tempVx;
                    balls[5].v.Y = tempVy;
                }
                */
                //pelota2	
                //2 con 3
                double distance23 = Math.Sqrt((balls[2].p.X - balls[3].p.X) * (balls[2].p.X - balls[3].p.X) + (balls[2].p.Y - balls[3].p.Y) * (balls[2].p.Y - balls[3].p.Y));

                if (distance23 <= (balls[2].size / 2) + (balls[3].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[2].v.X;
                    float tempVy = balls[2].v.Y;
                    balls[2].v.X = balls[3].v.X;
                    balls[2].v.Y = balls[3].v.Y;
                    balls[3].v.X = tempVx;
                    balls[3].v.Y = tempVy;
                }

                //2 con 4

                double distance24 = Math.Sqrt((balls[2].p.X - balls[4].p.X) * (balls[2].p.X - balls[4].p.X) + (balls[2].p.Y - balls[4].p.Y) * (balls[2].p.Y - balls[4].p.Y));

                if (distance24 <= (balls[2].size / 2)  + (balls[4].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[2].v.X;
                    float tempVy = balls[2].v.Y;
                    balls[2].v.X = balls[4].v.X;
                    balls[2].v.Y = balls[4].v.Y;
                    balls[4].v.X = tempVx;
                    balls[4].v.Y = tempVy;
                }
                //2 con 5
                /*	
                double distance25 = Math.Sqrt((balls[2].p.X - balls[5].p.X) * (balls[2].p.X - balls[5].p.X) + (balls[2].p.Y - balls[5].p.Y) * (balls[2].p.Y - balls[5].p.Y));

                if (distance25 <= (balls[2].size / 2) + (balls[5].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[2].v.X;
                    float tempVy = balls[2].v.Y;
                    balls[2].v.X = balls[5].v.X;
                    balls[2].v.Y = balls[5].v.Y;
                    balls[5].v.X = tempVx;
                    balls[5].v.Y = tempVy;
                }
                */
                //pelotta 3
                //3 con 4
                double distance34 = Math.Sqrt((balls[3].p.X - balls[4].p.X) * (balls[3].p.X - balls[4].p.X) + (balls[3].p.Y - balls[4].p.Y) * (balls[3].p.Y - balls[4].p.Y));

                if (distance34 <= (balls[3].size / 2) + (balls[4].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[3].v.X;
                    float tempVy = balls[3].v.Y;
                    balls[3].v.X = balls[4].v.X;
                    balls[3].v.Y = balls[4].v.Y;
                    balls[4].v.X = tempVx;
                    balls[4].v.Y = tempVy;
                }
                //3 con 5	
                /*
                double distance35 = Math.Sqrt((balls[3].p.X - balls[5].p.X) * (balls[3].p.X - balls[5].p.X) + (balls[3].p.Y - balls[5].p.Y) * (balls[3].p.Y - balls[5].p.Y));

                if (distance35 <= (balls[3].size / 2) + (balls[5].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[3].v.X;
                    float tempVy = balls[3].v.Y;
                    balls[3].v.X = balls[5].v.X;
                    balls[3].v.Y = balls[5].v.Y;
                    balls[5].v.X = tempVx;
                    balls[5].v.Y = tempVy;
                }
                

               double distance45 = Math.Sqrt((balls[4].p.X - balls[5].p.X) * (balls[4].p.X - balls[5].p.X) + (balls[4].p.Y - balls[5].p.Y) * (balls[4].p.Y - balls[5].p.Y));

                if (distance45 <= (balls[4].size / 2) + (balls[5].size / 2))
                {
                    // Swap velocities to simulate a bounce
                    float tempVx = balls[4].v.X;
                    float tempVy = balls[5].v.Y;
                    balls[4].v.X = balls[5].v.X;
                    balls[4].v.Y = balls[5].v.Y;
                    balls[5].v.X = tempVx;
                    balls[5].v.Y = tempVy;
                }
                */

                ball.Update(pictureBox1.Width, pictureBox1.Height);

            }

            pictureBox1.Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
