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
    public partial class frmThemChuyenBay : Form
    {
        QLBCMBEntities3 dt = new QLBCMBEntities3();
        public frmThemChuyenBay()
        {
            InitializeComponent();
        }

        private void frmThemChuyenBay_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.TimKiemNangCao("SB02", "SB04", "BamBoo", Convert.ToDateTime("2020-07-07"));

        }
    }
}
