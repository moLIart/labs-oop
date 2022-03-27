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
    public partial class ChooseCanvasSizeDialog : Form
    {
        public Size CanvasSize = new Size();
        public ChooseCanvasSizeDialog()
        {
            InitializeComponent();
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
