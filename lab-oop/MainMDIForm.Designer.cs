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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowToolStripMenuItem,
            this.windowToolStripMenuItem1,
            this.parametersToolStripMenuItem});
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
            this.chooseBorderWidthToolStripMenuItem});
            this.parametersToolStripMenuItem.Name = "parametersToolStripMenuItem";
            this.parametersToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.parametersToolStripMenuItem.Text = "Parameters";
            // 
            // chooseBaackgroundColorToolStripMenuItem
            // 
            this.chooseBaackgroundColorToolStripMenuItem.Name = "chooseBaackgroundColorToolStripMenuItem";
            this.chooseBaackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.chooseBaackgroundColorToolStripMenuItem.Text = "Choose background color...";
            this.chooseBaackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.chooseBaackgroundColorToolStripMenuItem_Click);
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
            this.chooseBorderWidthToolStripMenuItem.Text = "Choose border width";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "lab-02 mdi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}