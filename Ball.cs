using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallsDelTeacher
{
    public class Ball
    {
        public PointF p, v;
        public int size;
        public Color c;
        static Random rand = new Random();
        Size bound;

        public Ball(Size s) 
        { 
            bound = s;
            
            v = new PointF(rand.Next(-10, 10), rand.Next(-10, 10));
            c = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            size = rand.Next(20,50);
            p = new PointF(rand.Next(0, s.Width - size/2), rand.Next(0, s.Height - size/2));
        }

        public void Update(int maxX, int maxY) 
        {
            p.X += v.X;
            p.Y += v.Y;

            if((p.X - size/2) <0 || (p.X+size/2)> maxX)
            {
                v.X = -v.X;
            }
            if ((p.Y - size/2) < 0 ||( p.Y + size/2) > maxY)
            {
                v.Y = -v.Y;
            }

        }
        
        

        public override string ToString()
        {
            return p.ToString();
        }

    }
}
