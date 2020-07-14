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
    public partial class frmhoadon : Form
    {
        public frmhoadon()
        {
            InitializeComponent();
        }

        private void ttDSHoaDon_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
        }

        private void ttTongDoanhThu_ItemClick(object sender, TileItemEventArgs e)
        {
            DialogResult tl = XtraMessageBox.Show("Bạn muốn lựa chọn xem thông tin thống kê doanh thu theo năm ?", "Chú ý !"
                                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Form17 frm = new Form17();
                frm.ShowDialog();
            }
        }

        private void t_ItemClick(object sender, TileItemEventArgs e)
        {

            DialogResult tl = XtraMessageBox.Show("Bạn muốn lựa chọn xem thống kê doanh thu theo tháng ?", "Chú ý !"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                Form18 frm = new Form18();
                frm.ShowDialog();
            }
        }

        private void ttDoanhThuTheoThoiGian_ItemClick(object sender, TileItemEventArgs e)
        {

        }
    }
}
