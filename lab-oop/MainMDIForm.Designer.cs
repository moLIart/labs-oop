using System.Windows.Forms;

namespace lab_oop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBaackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBorderColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBorderWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseCanvasSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.figureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillingTypeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.figureRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.figureEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.figureStraightLine = new System.Windows.Forms.ToolStripMenuItem();
            this.figureArbitraryLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.lineWidthStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.penColorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fillingColorStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.canvasSizeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorPositionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.straightLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbitraryLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBorderClr = new System.Windows.Forms.ToolStripButton();
            this.toolStripBackClr = new System.Windows.Forms.ToolStripButton();
            this.toolStripChooseLineWidth = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripCanvasSize = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.mainStatusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.windowToolStripMenuItem1,
            this.parametersToolStripMenuItem,
            this.figureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem1;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.windowToolStripMenuItem.Text = "&File";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem1
            // 
            this.windowToolStripMenuItem1.Name = "windowToolStripMenuItem1";
            this.windowToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem1.Text = "&Window";
            // 
            // parametersToolStripMenuItem
            // 
            this.parametersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseBaackgroundColorToolStripMenuItem,
            this.chooseBorderColorToolStripMenuItem,
            this.chooseBorderWidthToolStripMenuItem,
            this.chooseCanvasSizeToolStripMenuItem,
            this.parametersToolStripMenuItem1});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // chooseBaackgroundColorToolStripMenuItem
            // 
            this.chooseBaackgroundColorToolStripMenuItem.Name = "chooseBaackgroundColorToolStripMenuItem";
            this.chooseBaackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.chooseBaackgroundColorToolStripMenuItem.Text = "Choose background color...";
            this.chooseBaackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.chooseBackgroundColorToolStripMenuItem_Click);
            // 
            // chooseBorderColorToolStripMenuItem
            // 
            this.chooseBorderColorToolStripMenuItem.Name = "chooseBorderColorToolStripMenuItem";
            this.chooseBorderColorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.chooseBorderColorToolStripMenuItem.Text = "Choose border color...";
            this.chooseBorderColorToolStripMenuItem.Click += new System.EventHandler(this.chooseBorderColorToolStripMenuItem_Click);
            // 
            // chooseBorderWidthToolStripMenuItem
            // 
            this.chooseBorderWidthToolStripMenuItem.Name = "chooseBorderWidthToolStripMenuItem";
            this.chooseBorderWidthToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.chooseBorderWidthToolStripMenuItem.Text = "Choose border width...";
            // 
            // chooseCanvasSizeToolStripMenuItem
            // 
            this.chooseCanvasSizeToolStripMenuItem.Name = "chooseCanvasSizeToolStripMenuItem";
            this.chooseCanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.chooseCanvasSizeToolStripMenuItem.Text = "Choose canvas size...";
            this.chooseCanvasSizeToolStripMenuItem.Click += new System.EventHandler(this.chooseCanvasSizeToolStripMenuItem_Click);
            // 
            // parametersToolStripMenuItem1
            // 
            this.parametersToolStripMenuItem1.Name = "parametersToolStripMenuItem1";
            this.parametersToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.parametersToolStripMenuItem1.Text = "Parameters";
            // 
            // figureToolStripMenuItem
            // 
            this.figureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillingTypeButton,
            this.figureRectangle,
            this.figureEllipse,
            this.figureStraightLine,
            this.figureArbitraryLine});
            this.figureToolStripMenuItem.Name = "figureToolStripMenuItem";
            this.figureToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.figureToolStripMenuItem.Text = "Figure";
            // 
            // fillingTypeButton
            // 
            this.fillingTypeButton.Name = "fillingTypeButton";
            this.fillingTypeButton.Size = new System.Drawing.Size(142, 22);
            this.fillingTypeButton.Text = "Filling";
            this.fillingTypeButton.Click += new System.EventHandler(this.changeFilling_Click);
            // 
            // figureRectangle
            // 
            this.figureRectangle.Name = "figureRectangle";
            this.figureRectangle.Size = new System.Drawing.Size(142, 22);
            this.figureRectangle.Tag = "0";
            this.figureRectangle.Text = "Rectangle";
            this.figureRectangle.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // figureEllipse
            // 
            this.figureEllipse.Name = "figureEllipse";
            this.figureEllipse.Size = new System.Drawing.Size(142, 22);
            this.figureEllipse.Tag = "1";
            this.figureEllipse.Text = "Ellipse";
            this.figureEllipse.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // figureStraightLine
            // 
            this.figureStraightLine.Name = "figureStraightLine";
            this.figureStraightLine.Size = new System.Drawing.Size(142, 22);
            this.figureStraightLine.Tag = "2";
            this.figureStraightLine.Text = "Straight line";
            this.figureStraightLine.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // figureArbitraryLine
            // 
            this.figureArbitraryLine.Name = "figureArbitraryLine";
            this.figureArbitraryLine.Size = new System.Drawing.Size(142, 22);
            this.figureArbitraryLine.Tag = "3";
            this.figureArbitraryLine.Text = "Arbitrary line";
            this.figureArbitraryLine.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineWidthStatusLabel,
            this.penColorStatusLabel,
            this.fillingColorStatusLabel,
            this.canvasSizeStatusLabel,
            this.cursorPositionStatusLabel});
            this.mainStatusBar.Location = new System.Drawing.Point(0, 428);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.ShowItemToolTips = true;
            this.mainStatusBar.Size = new System.Drawing.Size(800, 22);
            this.mainStatusBar.TabIndex = 3;
            this.mainStatusBar.Text = "statusStrip1";
            // 
            // lineWidthStatusLabel
            // 
            this.lineWidthStatusLabel.Name = "lineWidthStatusLabel";
            this.lineWidthStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.lineWidthStatusLabel.Text = "Pen width";
            // 
            // penColorStatusLabel
            // 
            this.penColorStatusLabel.AutoSize = false;
            this.penColorStatusLabel.AutoToolTip = true;
            this.penColorStatusLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.penColorStatusLabel.Name = "penColorStatusLabel";
            this.penColorStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.penColorStatusLabel.ToolTipText = "Setup pen color";
            // 
            // fillingColorStatusLabel
            // 
            this.fillingColorStatusLabel.AutoSize = false;
            this.fillingColorStatusLabel.AutoToolTip = true;
            this.fillingColorStatusLabel.Name = "fillingColorStatusLabel";
            this.fillingColorStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.fillingColorStatusLabel.ToolTipText = "Setup filling color";
            // 
            // canvasSizeStatusLabel
            // 
            this.canvasSizeStatusLabel.Name = "canvasSizeStatusLabel";
            this.canvasSizeStatusLabel.Size = new System.Drawing.Size(67, 17);
            this.canvasSizeStatusLabel.Text = "Canvas size";
            // 
            // cursorPositionStatusLabel
            // 
            this.cursorPositionStatusLabel.Name = "cursorPositionStatusLabel";
            this.cursorPositionStatusLabel.Size = new System.Drawing.Size(88, 17);
            this.cursorPositionStatusLabel.Text = "Cursor position";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewFile,
            this.toolStripOpenFile,
            this.toolStripSaveFile,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1,
            this.toolStripBorderClr,
            this.toolStripBackClr,
            this.toolStripChooseLineWidth,
            this.toolStripSeparator2,
            this.toolStripCanvasSize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewFile
            // 
            this.toolStripNewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewFile.Image")));
            this.toolStripNewFile.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripNewFile.Name = "toolStripNewFile";
            this.toolStripNewFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripNewFile.Text = "toolStripButton1";
            this.toolStripNewFile.ToolTipText = "New file";
            this.toolStripNewFile.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFile.Image")));
            this.toolStripOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenFile.Text = "Open file";
            this.toolStripOpenFile.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSaveFile
            // 
            this.toolStripSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveFile.Image")));
            this.toolStripSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveFile.Name = "toolStripSaveFile";
            this.toolStripSaveFile.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveFile.Text = "Save file";
            this.toolStripSaveFile.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rectangleToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.straightLineToolStripMenuItem,
            this.arbitraryLineToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ToolTipText = "Choose figure type";
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rectangleToolStripMenuItem.Tag = "0";
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ellipseToolStripMenuItem.Tag = "1";
            this.ellipseToolStripMenuItem.Text = "Ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // straightLineToolStripMenuItem
            // 
            this.straightLineToolStripMenuItem.Name = "straightLineToolStripMenuItem";
            this.straightLineToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.straightLineToolStripMenuItem.Tag = "2";
            this.straightLineToolStripMenuItem.Text = "Straight line";
            this.straightLineToolStripMenuItem.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // arbitraryLineToolStripMenuItem
            // 
            this.arbitraryLineToolStripMenuItem.Name = "arbitraryLineToolStripMenuItem";
            this.arbitraryLineToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.arbitraryLineToolStripMenuItem.Tag = "3";
            this.arbitraryLineToolStripMenuItem.Text = "Arbitrary line";
            this.arbitraryLineToolStripMenuItem.Click += new System.EventHandler(this.figureButton_Click);
            // 
            // toolStripBorderClr
            // 
            this.toolStripBorderClr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBorderClr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBorderClr.Image")));
            this.toolStripBorderClr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBorderClr.Name = "toolStripBorderClr";
            this.toolStripBorderClr.Size = new System.Drawing.Size(23, 22);
            this.toolStripBorderClr.Text = "toolStripButton1";
            this.toolStripBorderClr.Click += new System.EventHandler(this.changeFilling_Button);
            this.toolStripBorderClr.DoubleClick += new System.EventHandler(this.chooseBorderColorToolStripMenuItem_Click);
            // 
            // toolStripBackClr
            // 
            this.toolStripBackClr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBackClr.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBackClr.Image")));
            this.toolStripBackClr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBackClr.Name = "toolStripBackClr";
            this.toolStripBackClr.Size = new System.Drawing.Size(23, 22);
            this.toolStripBackClr.Text = "toolStripButton2";
            this.toolStripBackClr.Click += new System.EventHandler(this.changeFilling_Button);
            this.toolStripBackClr.DoubleClick += new System.EventHandler(this.chooseBackgroundColorToolStripMenuItem_Click);
            // 
            // toolStripChooseLineWidth
            // 
            this.toolStripChooseLineWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripChooseLineWidth.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChooseLineWidth.Image")));
            this.toolStripChooseLineWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChooseLineWidth.Name = "toolStripChooseLineWidth";
            this.toolStripChooseLineWidth.Size = new System.Drawing.Size(29, 22);
            this.toolStripChooseLineWidth.Text = "toolStripChooseLineWidth";
            this.toolStripChooseLineWidth.ToolTipText = "Choose line width";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripCanvasSize
            // 
            this.toolStripCanvasSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCanvasSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCanvasSize.Image")));
            this.toolStripCanvasSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCanvasSize.Name = "toolStripCanvasSize";
            this.toolStripCanvasSize.Size = new System.Drawing.Size(23, 22);
            this.toolStripCanvasSize.Text = "toolStripButton1";
            this.toolStripCanvasSize.Click += new System.EventHandler(this.chooseCanvasSizeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "lab-02 mdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainStatusBar.ResumeLayout(false);
            this.mainStatusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem windowToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem windowToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem parametersToolStripMenuItem;
        private ToolStripMenuItem chooseBaackgroundColorToolStripMenuItem;
        private ToolStripMenuItem chooseBorderColorToolStripMenuItem;
        private ToolStripMenuItem chooseBorderWidthToolStripMenuItem;
        private ToolStripMenuItem chooseCanvasSizeToolStripMenuItem;
        private ToolStripMenuItem figureToolStripMenuItem;
        private ToolStripMenuItem figureRectangle;
        private ToolStripMenuItem figureEllipse;
        private ToolStripMenuItem figureStraightLine;
        private ToolStripMenuItem figureArbitraryLine;
        private ToolStripMenuItem fillingTypeButton;
        private StatusStrip mainStatusBar;
        private ToolStripStatusLabel penColorStatusLabel;
        private ToolStripStatusLabel fillingColorStatusLabel;
        private ToolStripStatusLabel lineWidthStatusLabel;
        private ToolStripStatusLabel canvasSizeStatusLabel;
        private ToolStripStatusLabel cursorPositionStatusLabel;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripNewFile;
        private ToolStripButton toolStripOpenFile;
        private ToolStripButton toolStripSaveFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem rectangleToolStripMenuItem;
        private ToolStripMenuItem ellipseToolStripMenuItem;
        private ToolStripMenuItem straightLineToolStripMenuItem;
        private ToolStripMenuItem arbitraryLineToolStripMenuItem;
        private ToolStripMenuItem parametersToolStripMenuItem1;
        private ToolStripButton toolStripBorderClr;
        private ToolStripButton toolStripBackClr;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripCanvasSize;
        private ToolStripDropDownButton toolStripChooseLineWidth;
    }
}