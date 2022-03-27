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
        public DrawingForm()
        {
            InitializeComponent();
            this.canvasPanel.Size = Globals.canvasSize;

            rectangles = new List<MyRectangle>();
            DoubleBuffered = true;
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
        
        bool mouseDown = false;
        Point mouseDownPoint = Point.Empty;
        MyRectangle dragRectangle = new MyRectangle();
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

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseDownPoint = e.Location;
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragRectangle.X + dragRectangle.Width > canvasPanel.Width ||
                dragRectangle.Y + dragRectangle.Height > canvasPanel.Height)
            {
                mouseDown = false;
            }
            if (mouseDown)
            {
                dragRectangle.BackgroundColor = Globals.rectBackColor;
                dragRectangle.BorderColor = Globals.rectBorderColor;
                dragRectangle.BorderWidth = Globals.rectBorderWidth;
                rectangles.Add(new MyRectangle(dragRectangle));
                mouseDown = false;
                
            }
            canvasPanel.Refresh();
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                dragRectangle.X = Math.Min(mouseDownPoint.X, e.X);
                dragRectangle.Y = Math.Min(mouseDownPoint.Y, e.Y);
                dragRectangle.Width = Math.Abs(mouseDownPoint.X - e.X);
                dragRectangle.Height = Math.Abs(mouseDownPoint.Y - e.Y);
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

            if (mouseDown)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, dragRectangle.X, dragRectangle.Y, dragRectangle.Width, dragRectangle.Height);
            }
        }
    }
}
