using System;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawingForm form = new DrawingForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}