namespace WF_Home8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Escape_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int X = rnd.Next(this.Size.Width / 2, this.Size.Width - 17 - btn_Escape.Width);
            int Y = rnd.Next(0, this.Size.Height - 40 - btn_Escape.Height);

            Point point = new Point(X, Y);

            btn_Escape.Location = point;
        }

        string FileName;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                StreamReader sr = new StreamReader(FileName);

                while (!sr.EndOfStream)
                {
                    txtBoxText.Text += sr.ReadLine() + Environment.NewLine;
                }

                sr.Close();

            }

        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog.FileName;
                StreamWriter sw = new StreamWriter(FileName);

                sw.WriteLine(txtBoxText.Text);

                sw.Close();

            }

        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }
    }
}
