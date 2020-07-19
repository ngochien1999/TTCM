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
    public partial class frmtop3 : Form
    {
        public frmtop3()
        {
            InitializeComponent();
        }

        private void frmtop3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.banchay' table. You can move, or remove it, as needed.
            this.banchayTableAdapter.Fill(this.DataSet4.banchay);

            this.reportViewer1.RefreshReport();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
