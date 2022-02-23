using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class DrawingForm : Form
    {
        List<MyRectangle> rectangles = new List<MyRectangle>();
        public DrawingForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
        
        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        MyRectangle dragRectangle = new MyRectangle();
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            mouseDown = true;
            mouseDownPoint = e.Location;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (mouseDown) {
                rectangles.Add(new MyRectangle(dragRectangle));
                mouseDown = false;
                this.Refresh();
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (mouseDown) {
                dragRectangle.X = Math.Min(mouseDownPoint.X, e.X);
                dragRectangle.Y = Math.Min(mouseDownPoint.Y, e.Y);
                dragRectangle.Width = Math.Abs(mouseDownPoint.X - e.X);
                dragRectangle.Height = Math.Abs(mouseDownPoint.Y - e.Y);
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.Clear(Color.White);
            foreach (MyRectangle rect in rectangles) {
                rect.Draw(e.Graphics, pen);
            }
            
            if (mouseDown) {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                dragRectangle.Draw(e.Graphics, pen);
            }
        }
    }
}
