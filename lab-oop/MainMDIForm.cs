using System;
using System.IO;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "binp files (*.binp)|*.binp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = openFileDialog.OpenFile())
                {
                    DrawingForm drawingForm = new DrawingForm();
                    drawingForm.Text = openFileDialog.FileName;
                    drawingForm.MdiParent = this;
                    drawingForm.Show();
                    drawingForm.DeserializeDataFromStream(stream);
                    stream.Close();
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "binp files (*.binp)|*.binp|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream stream = saveFileDialog.OpenFile())
                {
                    DrawingForm drawingForm = (DrawingForm)this.ActiveMdiChild;
                    drawingForm.Text = saveFileDialog.FileName;
                    drawingForm.SerializeDataToStream(stream);
                    stream.Close();
                }
            }
        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = this.ActiveMdiChild != null;
        }
    }
}