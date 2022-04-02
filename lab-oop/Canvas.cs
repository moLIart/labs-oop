using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class Canvas : UserControl
    {
        List<MyRectangle> rectangles = new List<MyRectangle>();
        List<MyEllipse> ellipses = new List<MyEllipse>();
        List<MyStraightLine> straightLines = new List<MyStraightLine>();
        public Canvas()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
        }
        
        public void AddRectange(MyRectangle rect)
        {
            rectangles.Add(rect);
        }
        public void AddEllipse(MyEllipse ell)
        {
            ellipses.Add(ell);
        }
        public void AddLine(MyStraightLine line)
        {
            straightLines.Add(line);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            foreach (MyRectangle rect in rectangles)
            {
                rect.Draw(e.Graphics);
            }

            foreach (MyEllipse ell in ellipses)
            {
                ell.Draw(e.Graphics);
            }

            foreach (MyStraightLine sline in straightLines)
            {
                sline.Draw(e.Graphics);
            }
        }
    }
}
