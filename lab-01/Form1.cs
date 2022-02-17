using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab_01
{
    public partial class Form1 : Form
    {
        List<Point> points;
        public Form1()
        {
            points = new List<Point>();
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                points.Add(new Point(e.X, e.Y));
            } else if (e.Button == MouseButtons.Right) {
                points.Clear();
                MessageBox.Show("Нажата правая кнопка мыши");
            }
            this.pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            for (int i = 0; i < points.Count; i++) {
                string drawString = "(" + points[i].X + "; " + points[i].Y + ")";
                e.Graphics.DrawString(drawString, DefaultFont, new SolidBrush(Color.Black), points[i]);
            }
        }
    }
}