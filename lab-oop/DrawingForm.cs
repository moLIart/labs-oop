using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab_oop
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.canvasPanel.SetSize(Globals.canvasSize);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            var action = MessageBox.Show("Save", "Save file?", MessageBoxButtons.YesNoCancel);
            if (action == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "binp files (*.binp)|*.binp|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = saveFileDialog.OpenFile())
                    {
                        SerializeDataToStream(stream);
                        stream.Close();
                    }
                }
            } else if (action == DialogResult.Cancel) {
                e.Cancel = true;
            }
        }

        public void SerializeDataToStream(Stream stream)
        {
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            binFormater.Serialize(stream, this.canvasPanel.Size);
            this.canvasPanel.SerializeData(stream);
        }
        public void DeserializeDataFromStream(Stream stream)
        {
            // this code sucks :(
            var binFormater = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            this.canvasPanel.Size = (Size)binFormater.Deserialize(stream);
            this.canvasPanel.DeserializeData(stream);
        }

    }
}
