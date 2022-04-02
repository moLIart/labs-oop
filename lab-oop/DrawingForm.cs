using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class DrawingForm : Form
    {
        List<MyRectangle> rectangles;
        List<MyEllipse> ellipses;
        List<MyStraightLine> straightLines;
        public DrawingForm()
        {
            InitializeComponent();
            this.canvasPanel.Size = Globals.canvasSize;

            rectangles = new List<MyRectangle>();
            ellipses = new List<MyEllipse>();
            straightLines = new List<MyStraightLine>();

            DoubleBuffered = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            var action = MessageBox.Show("Save", "Save file?", MessageBoxButtons.YesNoCancel);
            if (action == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "binp files (*.binp)|*.binp|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFileDialog.OpenFile())
                    {
                        SerializeDataToStream(stream);
                        stream.Close();
                    }
                }
            } else if (action == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        MyRectangle dragRectangle = new MyRectangle();
        MyStraightLine dragLine = new MyStraightLine();

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownPoint = e.Location;
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MyRectangle canvasRect = new MyRectangle(0, 0, canvasPanel.Width, canvasPanel.Height);
            if (!canvasRect.IsContain(dragRectangle)) mouseDown = false;

            if (mouseDown)
            {
                switch (Globals.figureType)
                {
                    case (int)FigureType.Rectangle:
                    case (int)FigureType.Ellipse:
                        dragRectangle.BackgroundColor = Globals.rectBackColor;
                        dragRectangle.BorderColor = Globals.rectBorderColor;
                        dragRectangle.BorderWidth = Globals.rectBorderWidth;
                        dragRectangle.isFilling = Globals.isFilling;
                        if (Globals.figureType == (int)FigureType.Rectangle)
                            rectangles.Add(new MyRectangle(dragRectangle));
                        else
                            ellipses.Add(new MyEllipse(dragRectangle));
                        break;
                    case (int)FigureType.StraightLine:
                        dragLine.Color = Globals.rectBorderColor;
                        dragLine.Width = Globals.rectBorderWidth;
                        straightLines.Add(new MyStraightLine(dragLine));
                        break;
                }

                mouseDown = false;
            }
            canvasPanel.Refresh();
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) 
            { 
                switch(Globals.figureType)
                {
                    case (int)FigureType.Rectangle:
                    case (int)FigureType.Ellipse:
                        dragRectangle.X = Math.Min(mouseDownPoint.X, e.X);
                        dragRectangle.Y = Math.Min(mouseDownPoint.Y, e.Y);
                        dragRectangle.Width = Math.Abs(mouseDownPoint.X - e.X);
                        dragRectangle.Height = Math.Abs(mouseDownPoint.Y - e.Y);
                        break;
                    case (int)FigureType.StraightLine:
                        dragLine.X = mouseDownPoint.X;
                        dragLine.Y = mouseDownPoint.Y;
                        dragLine.X1 = e.X;
                        dragLine.Y1 = e.Y;
                        goto case (int)FigureType.Rectangle;
                }
                canvasPanel.Refresh();
            }
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            foreach (MyRectangle rect in rectangles)
            {
                rect.Draw(e.Graphics);
            }

            foreach (MyEllipse ell in ellipses)
            {
                ell.Draw(e.Graphics);
            }

            foreach(MyStraightLine sline in straightLines)
            {
                sline.Draw(e.Graphics);
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
                        e.Graphics.DrawLine(pen, dragLine.X, dragLine.Y, dragLine.X1, dragLine.Y1);
                        break;
                }

            }
        }

        public void SerializeDataToStream(Stream stream)
        {
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binFormater.Serialize(stream, this.canvasPanel.Size);
            binFormater.Serialize(stream, rectangles);
        }
        public void DeserializeDataFromStream(Stream stream)
        {
            // this code sucks :(
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            this.canvasPanel.Size = (Size)binFormater.Deserialize(stream);
            rectangles = new List<MyRectangle>((List<MyRectangle>)binFormater.Deserialize(stream));
        }

    }
}
