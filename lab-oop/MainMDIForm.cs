using System;
using System.Diagnostics;
using System.Drawing;
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            int[] widthArr = new int[] { 1, 2, 5, 8, 10, 12, 15 };
            for (int i = 0; i < 7; i++) {
                ToolStripMenuItem item = new ToolStripMenuItem(widthArr[i].ToString());
                item.Tag = widthArr[i];
                item.Click += new EventHandler(this.rectBorderWidth_Click);
                this.chooseBorderWidthToolStripMenuItem.DropDownItems.Add(item);             
            }
            UpdateFigureType(Globals.figureType);
        }
        private void UpdateFigureType(int figType)
        {
            this.figureRectangle.Checked = false;
            this.figureEllipse.Checked = false;
            this.figureStraightLine.Checked = false;
            this.figureArbitraryLine.Checked = false;

            switch (figType)
            {
                case (int)FigureType.Rectangle:
                    this.figureRectangle.Checked = true;
                    break;
                case (int)FigureType.Ellipse:
                    this.figureEllipse.Checked = true;
                    break;
                case (int)FigureType.StraightLine:
                    this.figureStraightLine.Checked = true;
                    break;
                case (int)FigureType.ArbitraryLine:
                    this.figureArbitraryLine.Checked = true;
                    break;
                default:
                    Debug.Assert(false, "unknown figure type");
                    break;
            }
            this.fillingTypeButton.Enabled = figType < 2;
            Globals.figureType = figType;
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

        private void chooseBaackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = Globals.rectBackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                Globals.rectBackColor = MyDialog.Color;
        }

        private void chooseBorderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = Globals.rectBorderColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                Globals.rectBorderColor = MyDialog.Color;
        }

        private void chooseCanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseCanvasSizeDialog dialog = new ChooseCanvasSizeDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Globals.canvasSize = dialog.CanvasSize;
            }
        }

        private void rectBorderWidth_Click(object sender, EventArgs e)
        {
            Globals.rectBorderWidth = (int)((ToolStripMenuItem)sender).Tag;
        }
        private void figureButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            UpdateFigureType(Int32.Parse((string)item.Tag));
        }

        private void changeFilling_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            Globals.isFilling = item.Checked;
        }
    }
}