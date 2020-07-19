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
    public partial class frminhoadon : Form
    {
        private string mahoadon;
        public frminhoadon()
        {
            InitializeComponent();
        }
        public frminhoadon(string mahoadon)
        {
            this.Mahoadon = mahoadon;
            InitializeComponent();
          
        }

        public string Mahoadon { get => mahoadon; set => mahoadon = value; }

        private void Form16_Load(object sender, EventArgs e)
        {
            MessageBox.Show(mahoadon);
            // TODO: This line of code loads data into the 'QLBCMBDataSet20.RPhoadon' table. You can move, or remove it, as needed.
            this.RPhoadonTableAdapter.Fill(this.QLBCMBDataSet20.RPhoadon,mahoadon);

            this.reportViewer1.RefreshReport();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
