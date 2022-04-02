using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    [Serializable]
    public class MyArbitraryLine : Figure
    {
        public List<Point> Points;
        public Color Color { get; set; }
        public int Width { get; set; }
        public MyArbitraryLine() 
        {
            Points = new List<Point>();
        }
        public MyArbitraryLine(MyArbitraryLine other)
        {
            this.Color = other.Color;
            this.Width = other.Width;
            this.Points = other.Points;
        }

        public void AddPoint(Point p)
        {
            if (Points.Count > 1) { 
                Point last = Points[Points.Count - 1];
                if (Math.Sqrt((last.X - p.X)*(last.X - p.X) + (last.Y - p.Y) *(last.Y - p.Y)) > 6)
                    this.Points.Add(p);
            } else
                this.Points.Add(p);
        }

        public bool IsContain(MyRectangle other)
        {
            if (Points.Count < 1) return false;
            Point last = this.Points[this.Points.Count - 1];
            return last.X > other.X && last.Y > other.Y && last.X < (other.X + other.Width) && last.Y < (other.Y + other.Height);
        }
        public override void Draw(Graphics g)
        {
            g.DrawCurve(new Pen(Color, Width), Points.ToArray());
        }
    }
}
