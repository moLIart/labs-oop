using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    [Serializable]
    public class MyStraightLine : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public Color Color { get; set; }
        public int Width { get; set; }

        public MyStraightLine() { }
        public MyStraightLine(MyStraightLine other)
        {
            X = other.X;
            Y = other.Y;
            X1 = other.X1;
            Y1 = other.Y1;
            Color = other.Color;
            Width = other.Width;
        }
        public override void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color, Width), X, Y, X1, Y1);
        }
    }
}
