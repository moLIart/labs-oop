using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_oop
{
    [Serializable]
    public class MyRectangle : Figure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Color BorderColor { get; set; }
        public int BorderWidth { get; set; }
        public Color BackgroundColor { get; set; }

        public bool isFilling { get; set; }

        public MyRectangle() { }
        public MyRectangle(int X, int Y, int Width, int Height) { 
            this.X = X;
            this.Y = Y; 
            this.Width = Width; 
            this.Height = Height;
        }
        public MyRectangle(MyRectangle other) {
            X = other.X;
            Y = other.Y;
            Width = other.Width;
            Height = other.Height;
            BorderColor = other.BorderColor;
            BorderWidth = other.BorderWidth;
            BackgroundColor = other.BackgroundColor;
            isFilling = other.isFilling;
        }

        public bool IsContain (MyRectangle other)
        {
            return (X < other.X && Y < other.Y) && ((X + Width) > (other.X + other.Width) && (Y + Height) > (other.Y + other.Height));
        }
        public override void Draw(Graphics g) {
            Pen borderPen = new Pen(BorderColor, BorderWidth);
            Brush brush = new SolidBrush(BackgroundColor);
            if (isFilling) g.FillRectangle(brush, X, Y, Width, Height);
            g.DrawRectangle(borderPen, X, Y, Width, Height);
        }
    }
}
