using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            loadform(new Form3());
        }
        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Opacity = 0;
            fh.Show();
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
            loadform(new Form10());
        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            loadform(new Form12());
        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {
            loadform(new Form5());
        }

        private void GunaButton7_Click(object sender, EventArgs e)
        {
            loadform(new Form9());
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            loadform(new Form8());
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            frmhoadon f = new frmhoadon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
