using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    internal class MyRectangle : Figure
    {
        public static readonly MyRectangle Empty = new MyRectangle();
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public MyRectangle() { }
        public MyRectangle(MyRectangle other) {
            X = other.X;
            Y = other.Y;
            Width = other.Width;
            Height = other.Height;
        }
        public MyRectangle(int X, int Y, int Width, int Height)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
        }
        public override void Draw(Graphics g, Pen pen) {
            g.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
