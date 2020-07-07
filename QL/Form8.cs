using DevExpress.XtraEditors;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void ttDSHoaDon_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult tl = XtraMessageBox.Show("Bạn muốn lựa chọn In thông tin Danh Sách Hóa Đơn ?", "Chú ý !"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
               Form3 frm = new Form3();
                frm.ShowDialog();
            }
        }

        private void ttTongDoanhThu_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}
