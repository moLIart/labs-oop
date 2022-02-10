namespace lab_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.MdiParent = this;
            form.FormClosed += (closedSender, closedE) => {
                form = null;
            };
            form.Show();

            this.windowToolStripMenuItem.DropDownItems.Add(new ToolStripButton(form.Text));
        }

    }
}