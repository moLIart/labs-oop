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

            // setup
            int[] widthArr = new int[] { 1, 2, 5, 8, 10, 12, 15 };
            for (int i = 0; i < 7; i++) {
                ToolStripMenuItem item = new ToolStripMenuItem(widthArr[i].ToString());
                item.Tag = widthArr[i];
                item.Click += new EventHandler(this.rectBorderWidth_Click);
                this.toolStripChooseLineWidth.DropDownItems.Add(item);

                // c# sucks
                ToolStripMenuItem item1 = new ToolStripMenuItem(widthArr[i].ToString());
                item1.Tag = widthArr[i];
                item1.Click += new EventHandler(this.rectBorderWidth_Click);
                this.chooseBorderWidthToolStripMenuItem.DropDownItems.Add(item1);
            }
            UpdateFigureType(Globals.figureType);

            // ... & update status bar
            UpdateStatusBar();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // sucks ...
            this.UpdateStatusBar();
        }

        private void UpdateFigureType(int figType)
        {
            this.figureRectangle.Checked = false;
            this.figureEllipse.Checked = false;
            this.figureStraightLine.Checked = false;
            this.figureArbitraryLine.Checked = false;

            this.rectangleToolStripMenuItem.Checked = false;
            this.ellipseToolStripMenuItem.Checked = false;
            this.straightLineToolStripMenuItem.Checked = false;
            this.arbitraryLineToolStripMenuItem.Checked = false;

            switch (figType)
            {
                case (int)FigureType.Rectangle:
                    this.figureRectangle.Checked = true;
                    this.rectangleToolStripMenuItem.Checked = true;
                    break;
                case (int)FigureType.Ellipse:
                    this.figureEllipse.Checked = true;
                    this.ellipseToolStripMenuItem.Checked = true;
                    break;
                case (int)FigureType.StraightLine:
                    this.figureStraightLine.Checked = true;
                    this.straightLineToolStripMenuItem.Checked = true;
                    break;
                case (int)FigureType.ArbitraryLine:
                    this.figureArbitraryLine.Checked = true;
                    this.arbitraryLineToolStripMenuItem.Checked = true;
                    break;
                default:
                    Debug.Assert(false, "unknown figure type");
                    break;
            }
            this.fillingTypeButton.Enabled = figType < 2;
            this.fillingTypeButton.Checked = Globals.isFilling;

            this.toolStripBorderClr.Checked = !Globals.isFilling;

            this.toolStripBackClr.Enabled = figType < 2;
            this.toolStripBackClr.Checked = Globals.isFilling;
            Globals.figureType = figType;
        }
        private void UpdateStatusBar()
        {
            this.lineWidthStatusLabel.Text = "Pen width: " + Globals.rectBorderWidth;
            this.penColorStatusLabel.BackColor = Globals.rectBorderColor;
            this.fillingColorStatusLabel.BackColor = Globals.rectBackColor;

            // sucks ...
            this.canvasSizeStatusLabel.Text = "Canvas size: (" + Globals.canvasSize.Width + ", " + Globals.canvasSize.Height + ")";
            if (Globals.cursorPosition != new Point(-1, -1))
                this.cursorPositionStatusLabel.Text = "Cursor pos: (" + Globals.cursorPosition.X + ", " + Globals.cursorPosition.Y + ")";
            else
                this.cursorPositionStatusLabel.Text = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawingForm form = new DrawingForm();
            form.ClientSize = Globals.canvasSize;
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

        private void chooseBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // setup 
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = Globals.rectBackColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                Globals.rectBackColor = MyDialog.Color;

            // ... & update status
            UpdateStatusBar();
        }

        private void chooseBorderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // setup
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = Globals.rectBorderColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
                Globals.rectBorderColor = MyDialog.Color;

            // ... & update status
            UpdateStatusBar();
        }

        private void chooseCanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // setup
            ChooseCanvasSizeDialog dialog = new ChooseCanvasSizeDialog(Globals.canvasSize);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Globals.canvasSize = dialog.CanvasSize;
            }

            // ... & update
            UpdateStatusBar();
        }

        private void rectBorderWidth_Click(object sender, EventArgs e)
        {
            // setup 
            Globals.rectBorderWidth = (int)((ToolStripMenuItem)sender).Tag;

            // update status bar
            UpdateStatusBar();
        }
        private void figureButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            UpdateFigureType(Int32.Parse((string)item.Tag));
        }

        private void changeFilling_Click(object sender, EventArgs e)
        {
            this.toolStripBorderClr.Checked = false;
            this.toolStripBackClr.Checked = false;


            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            
            // sucks...
            this.toolStripBackClr.Checked = item.Checked;
            this.toolStripBorderClr.Checked = !item.Checked;
            
            Globals.isFilling = item.Checked;
        }

        private void changeFilling_Button(object sender, EventArgs e)
        {
            this.fillingTypeButton.Checked = false;
            this.toolStripBorderClr.Checked = false;
            this.toolStripBackClr.Checked = false;

            ToolStripButton item = (ToolStripButton)sender;
            item.Checked = !item.Checked;

            // sucks...
            this.fillingTypeButton.Checked = item.Checked;

            Globals.isFilling = item.Checked;
        }
    }
}