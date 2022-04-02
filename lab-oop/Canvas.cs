using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class Canvas : UserControl
    {

        List<Figure> figures = new List<Figure>();
        public Canvas()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
        }

        public void SetSize(Size size)
        {
            this.Size = size;  
        }
        
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

        public void SerializeData(Stream stream)
        {
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binFormater.Serialize(stream, this.figures);
//            binFormater.Serialize(stream, this.rectangles);
//            binFormater.Serialize(stream, this.ellipses);
//            binFormater.Serialize(stream, this.sLines);
//            binFormater.Serialize(stream, this.aLines);
        }

        public void DeserializeData(Stream stream)
        {
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            this.figures = new List<Figure>((List<Figure>)binFormater.Deserialize(stream));
            //this.rectangles = new List<MyRectangle>((List<MyRectangle>)binFormater.Deserialize(stream));
            //this.ellipses = new List<MyEllipse>((List<MyEllipse>)binFormater.Deserialize(stream));
            //this.sLines = new List<MyStraightLine>((List<MyStraightLine>)binFormater.Deserialize(stream));
            //this.aLines = new List<MyArbitraryLine>((List<MyArbitraryLine>)binFormater.Deserialize(stream));
        }

        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        Point curPoint = Point.Empty;
        MyRectangle dragRectangle = new MyRectangle();
        MyStraightLine dragSLine = new MyStraightLine();
        MyArbitraryLine dragArbLine;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownPoint = e.Location;
            if (Globals.figureType == (int)FigureType.ArbitraryLine)
            {
                dragArbLine = new MyArbitraryLine();
                dragArbLine.AddPoint(mouseDownPoint);
                timer.Start();
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            MyRectangle canvasRect = new MyRectangle(0, 0, Width, Height);
            if (mouseDown)
            {
                switch (Globals.figureType)
                {
                    case (int)FigureType.Rectangle:
                    case (int)FigureType.Ellipse:
                        if (!canvasRect.IsContain(dragRectangle)) break;
                        dragRectangle.BackgroundColor = Globals.rectBackColor;
                        dragRectangle.BorderColor = Globals.rectBorderColor;
                        dragRectangle.BorderWidth = Globals.rectBorderWidth;
                        dragRectangle.isFilling = Globals.isFilling;
                        if (Globals.figureType == (int)FigureType.Rectangle)
                            this.AddFigure(new MyRectangle(dragRectangle));
                        else
                            this.AddFigure(new MyEllipse(dragRectangle));
                        break;
                    case (int)FigureType.StraightLine:
                        dragSLine.Color = Globals.rectBorderColor;
                        dragSLine.Width = Globals.rectBorderWidth;
                        this.AddFigure(new MyStraightLine(dragSLine));
                        break;
                    case (int)FigureType.ArbitraryLine:
                        if (!dragArbLine.IsContain(canvasRect)) break;
                        dragArbLine.Color = Globals.rectBorderColor;
                        dragArbLine.Width = Globals.rectBorderWidth;
                        this.AddFigure(dragArbLine);
                        this.timer.Stop();
                        break;
                }
                mouseDown = false;
            }
            this.Refresh();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (mouseDown)
            {
                switch (Globals.figureType)
                {
                    case (int)FigureType.Rectangle:
                    case (int)FigureType.Ellipse:
                        dragRectangle.X = Math.Min(mouseDownPoint.X, e.X);
                        dragRectangle.Y = Math.Min(mouseDownPoint.Y, e.Y);
                        dragRectangle.Width = Math.Abs(mouseDownPoint.X - e.X);
                        dragRectangle.Height = Math.Abs(mouseDownPoint.Y - e.Y);
                        break;
                    case (int)FigureType.StraightLine:
                        dragSLine.X = mouseDownPoint.X;
                        dragSLine.Y = mouseDownPoint.Y;
                        dragSLine.X1 = e.X;
                        dragSLine.Y1 = e.Y;
                        goto case (int)FigureType.Rectangle;
                    case (int)FigureType.ArbitraryLine:
                        this.curPoint = e.Location;
                        break;
                }
                this.Refresh();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(this.BackColor);

            foreach (Figure figure in figures)
            {
                figure.Draw(e.Graphics);
            }

            if (mouseDown)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                switch (Globals.figureType)
                {
                    case (int)FigureType.Rectangle:
                        e.Graphics.DrawRectangle(pen, dragRectangle.X, dragRectangle.Y, dragRectangle.Width, dragRectangle.Height);
                        break;
                    case (int)FigureType.Ellipse:
                        e.Graphics.DrawEllipse(pen, dragRectangle.X, dragRectangle.Y, dragRectangle.Width, dragRectangle.Height);
                        break;
                    case (int)FigureType.StraightLine:
                        e.Graphics.DrawLine(pen, dragSLine.X, dragSLine.Y, dragSLine.X1, dragSLine.Y1);
                        break;
                    case (int)FigureType.ArbitraryLine:
                        if (this.dragArbLine.Points.Count < 2) break;
                        e.Graphics.DrawCurve(pen, this.dragArbLine.Points.ToArray());
                        break;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (mouseDown && Globals.figureType == (int)FigureType.ArbitraryLine)
            {
                this.dragArbLine.AddPoint(curPoint);
            }
        }
    }
}
