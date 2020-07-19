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
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

            DialogResult tl = MessageBox.Show("Bạn muốn lựa chọn xem thống kê doanh thu theo tháng ?", "Chú ý !"
                                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                frmtheothang frm = new frmtheothang();
                frm.ShowDialog();
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn lựa chọn xem thông tin thống kê tổng doanh thu ?", "Chú ý !"
                                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                frmtongdt frm = new frmtongdt();
                frm.ShowDialog();
            }
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //app.Visible = true;
            //// Dua du lieu vao excel
            //worksheet.Cells[1, 10] = "Báo Cáo hóa đơn";
            //worksheet.Cells[3, 1] = "STT";
            //worksheet.Cells[3, 2] = "Mã hóa đơn";
            //worksheet.Cells[3, 3] = "Tên nhân viên";
            //worksheet.Cells[3, 4] = "Tên khách hàng";
            //worksheet.Cells[3, 5] = "Tên hoa";
            //worksheet.Cells[3, 6] = "Số lượng";
            //worksheet.Cells[3, 7] = "Đơn giá";
            //worksheet.Cells[3, 8] = "Tổng tiền";
            //worksheet.Cells[3, 9] = "Mã giờ vàng";
            //worksheet.Cells[3, 10] = "Ngày lập hóa đơn";

        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn lựa chọn xem thông tin thống kê doanh thu theo năm ?", "Chú ý !"
                                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                frmdttn frm = new frmdttn();
                frm.ShowDialog();
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn muốn lựa chọn xem thông tin thống kê top 3 chuyến bay được mua nhiều nhất ?", "Chú ý !"
                                  , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tl == DialogResult.Yes)
            {
                frmtop3 frm = new frmtop3();
                frm.ShowDialog();
            }
        }
    }
}
