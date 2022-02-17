using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_02
{
    public partial class Form2 : Form
    {
        List<Rectangle> rectangles = new List<Rectangle>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.Clear(Color.White);
            foreach (Rectangle rect in rectangles) {
                e.Graphics.DrawRectangle(pen, rect);
            }
            
            if (drawing) {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, curRect);
            }
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }


        bool drawing = false, pressed = false;
        Point startP = new Point();
        Rectangle curRect = new Rectangle();
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            startP.X = e.X;
            startP.Y = e.Y;

            curRect.X = curRect.Width = e.X;
            curRect.Y = curRect.Height = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed) {
                drawing = true;
                if (e.X < startP.X || e.X < startP.Y) {
                    curRect.X = e.X;
                    curRect.Y = e.Y;
                    curRect.Width = startP.X - e.X;
                    curRect.Height = startP.Y - e.Y;
                } else {
                    curRect.Width = e.X - curRect.X;
                    curRect.Height = e.Y - curRect.Y;
                }
                this.Refresh();
            }
        } 

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing) {
                rectangles.Add(curRect);
                pressed = drawing = false;
            }
            this.Refresh();
        }
    }
}
