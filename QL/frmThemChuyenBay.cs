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
        public frmThemChuyenBay()
        {
            InitializeComponent();
        }

        private void frmThemChuyenBay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.Maybay' table. You can move, or remove it, as needed.
            this.maybayTableAdapter.Fill(this.duLieu.Maybay);

        }
    }
}
