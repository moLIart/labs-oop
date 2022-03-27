namespace lab_oop
{
    partial class ChooseCanvasSizeDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radio320x240 = new System.Windows.Forms.RadioButton();
            this.radio640x480 = new System.Windows.Forms.RadioButton();
            this.radio800x600 = new System.Windows.Forms.RadioButton();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.widthCtrl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightCtrl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // radio320x240
            // 
            this.radio320x240.AutoSize = true;
            this.radio320x240.Location = new System.Drawing.Point(12, 12);
            this.radio320x240.Name = "radio320x240";
            this.radio320x240.Size = new System.Drawing.Size(67, 19);
            this.radio320x240.TabIndex = 0;
            this.radio320x240.TabStop = true;
            this.radio320x240.Text = "320x240";
            this.radio320x240.UseVisualStyleBackColor = true;
            // 
            // radio640x480
            // 
            this.radio640x480.AutoSize = true;
            this.radio640x480.Location = new System.Drawing.Point(12, 37);
            this.radio640x480.Name = "radio640x480";
            this.radio640x480.Size = new System.Drawing.Size(67, 19);
            this.radio640x480.TabIndex = 1;
            this.radio640x480.TabStop = true;
            this.radio640x480.Text = "640x480";
            this.radio640x480.UseVisualStyleBackColor = true;
            // 
            // radio800x600
            // 
            this.radio800x600.AutoSize = true;
            this.radio800x600.Location = new System.Drawing.Point(12, 62);
            this.radio800x600.Name = "radio800x600";
            this.radio800x600.Size = new System.Drawing.Size(67, 19);
            this.radio800x600.TabIndex = 2;
            this.radio800x600.TabStop = true;
            this.radio800x600.Text = "800x600";
            this.radio800x600.UseVisualStyleBackColor = true;
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.Location = new System.Drawing.Point(85, 12);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(53, 19);
            this.radioOther.TabIndex = 3;
            this.radioOther.TabStop = true;
            this.radioOther.Text = "other";
            this.radioOther.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(160, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(241, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // widthCtrl
            // 
            this.widthCtrl.Location = new System.Drawing.Point(196, 12);
            this.widthCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.widthCtrl.Name = "widthCtrl";
            this.widthCtrl.Size = new System.Drawing.Size(120, 23);
            this.widthCtrl.TabIndex = 6;
            this.widthCtrl.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Height:";
            // 
            // heightCtrl
            // 
            this.heightCtrl.Location = new System.Drawing.Point(196, 47);
            this.heightCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.heightCtrl.Name = "heightCtrl";
            this.heightCtrl.Size = new System.Drawing.Size(120, 23);
            this.heightCtrl.TabIndex = 8;
            this.heightCtrl.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // ChooseCanvasSizeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.heightCtrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthCtrl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioOther);
            this.Controls.Add(this.radio800x600);
            this.Controls.Add(this.radio640x480);
            this.Controls.Add(this.radio320x240);
            this.Name = "ChooseCanvasSizeDialog";
            this.Text = "Choose Canvas Size";
            ((System.ComponentModel.ISupportInitialize)(this.widthCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio320x240;
        private System.Windows.Forms.RadioButton radio640x480;
        private System.Windows.Forms.RadioButton radio800x600;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown widthCtrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heightCtrl;
    }
}