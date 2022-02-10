using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                e.Graphics.DrawRectangle(pen, currentRect);
            }
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }


        bool drawing = false, pressed = false;
        Rectangle currentRect = new Rectangle();
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            pressed = true;
            currentRect.X = currentRect.Width = e.X;
            currentRect.Y = currentRect.Height = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (pressed) {
                drawing = true;
                currentRect.Width = e.X - currentRect.X;
                currentRect.Height = e.Y - currentRect.Y;
                this.Refresh();
            }
        } 

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing) {
                rectangles.Add(currentRect);
                pressed = drawing = false;
            }
            this.Refresh();
        }
    }
}
