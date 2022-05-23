using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class ChooseCanvasSizeDialog : Form
    {
        public Size CanvasSize = new Size();
        public ChooseCanvasSizeDialog()
        {
            InitializeComponent();
        }

        public ChooseCanvasSizeDialog(Size canvasSize)
        {
            InitializeComponent();

            Debug.Assert(canvasSize.Width < 1000 || canvasSize.Height < 1000);

            int size = canvasSize.Width * 1000 + canvasSize.Height;
            switch(size)
            {
                case 320240:
                    radio320x240.Checked = true;
                    break;
                case 640480:
                    radio640x480.Checked = true;
                    break;
                case 800600:
                    radio800x600.Checked = true;
                    break;
                default:
                    radioOther.Checked = true;
                    widthCtrl.Value = canvasSize.Width;
                    heightCtrl.Value = canvasSize.Height;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio320x240.Checked)
            {
                CanvasSize.Width = 320;
                CanvasSize.Height = 240;
            } else if (radio640x480.Checked)
            {
                CanvasSize.Width = 640;
                CanvasSize.Height = 480;
            } else if (radio800x600.Checked)
            {
                CanvasSize.Width = 800;
                CanvasSize.Height = 600;
            }
            else if (radioOther.Checked)
            {
                CanvasSize.Width = Decimal.ToInt32(this.widthCtrl.Value);
                CanvasSize.Height = Decimal.ToInt32(this.heightCtrl.Value);
            }
        }
    }
}
