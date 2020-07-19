using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QL
{

    public partial class frmkhachhang : Form
    {
        QLBCMBEntities3 quanlichuan = new QLBCMBEntities3();
        public frmkhachhang()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBCMBDataSet13.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBCMBDataSet13.Khachhang);
            DSBItems();
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;

        }
        string makh = "";
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtcmnd.Text == "" || txtemail.Text == "" || txttuoi.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txttuoi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtsdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtdiachi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtcmnd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtemail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                btnsua.Enabled = true;
            }
            catch
            {
                btnsua.Enabled = false;
            }
            if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà khách hàng không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                    {
                        quanli.deletekh(makh);
                        MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        Form8_Load(sender, e);
                    }
                }
            }

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            clearData();
            dataGridView1.Enabled = false;
            EnableItem();
            temp = true;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                quanli.deletekh(makh);
                quanli.SaveChanges();
                MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form8_Load(sender, e);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            temp = false;
            EnableItem();
            dataGridView1.Enabled = false;
            btnthem.Enabled = false;
        }
        private void clearData()
        {
            txtten.Text = "";
            txttuoi.Text = "";
            txtdiachi.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
           
        }
        private void DSBItems()
        {
            btnLuu.Enabled = false;
            btnsua.Enabled = false;
            btnHuy.Enabled = false;
            txtten.Enabled = false;
            txtsdt.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            txtdiachi.Enabled = false;
            txtcmnd.Enabled = false;
         
        }
        private void EnableItem()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            
        
            txtten.Enabled = true;
            txtsdt.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            txtdiachi.Enabled = true;
            txtcmnd.Enabled = true;

        }
        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                dataGridView1.DataSource = quanli.Khachhangs.Where(p => p.Makh.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
        private bool temp;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (temp)
            {
                if (!kiemtra())
                {
                    return;
                }
                {
                   
                    using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                    {
                        string makh = quanli.Khachhangs.Max(p => p.Makh);
                        string ma = makh.Substring(2, makh.Length - 2);
                        int manhanvien = int.Parse(ma) + 1;
                        if (manhanvien <= 9)
                            makh = "KH0" + manhanvien;
                        else
                            makh = "KH" + manhanvien;
                        Khachhang kh = new Khachhang();
                        kh.Makh = makh;
                        kh.Tenkh = txtten.Text;
                        kh.Tuoi = int.Parse(txttuoi.Text);
                        kh.SDTkh = txtsdt.Text;
                        kh.ĐCkh = txtdiachi.Text;
                        kh.CMND = int.Parse(txtcmnd.Text);
                        kh.Email = txtemail.Text;
                        quanli.Khachhangs.Add(kh);
                        quanli.SaveChanges();
                        Form8_Load(sender, e);
                        btnthem.Enabled = true;
                     
                        clearData();
                        dataGridView1.Enabled = true;
                       
                    }
                }
            }
            {
                if (makh == "")
                {
                    MessageBox.Show("Hãy chọn khách hàng cần sửa!");
                    return;
                }
                using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                {
                    Khachhang kh = quanli.Khachhangs.FirstOrDefault(p => p.Makh == makh);

                    kh.Makh = makh;
                    kh.Tenkh = txtten.Text;
                    kh.Tuoi = int.Parse(txttuoi.Text);
                    kh.SDTkh = txtsdt.Text;
                    kh.ĐCkh = txtdiachi.Text;
                    kh.CMND = int.Parse(txtcmnd.Text);
                    kh.Email = txtemail.Text;
                    quanli.SaveChanges();
                    MessageBox.Show("Sua thanh cong!");
                    Form8_Load(sender, e);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSBItems();
            clearData();
            btnthem.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 10] = "Báo cáo danh sách khách hàng";
            worksheet.Cells[3, 1] = "Mã KH";
            worksheet.Cells[3, 2] = "Họ và tên KH";
            worksheet.Cells[3, 3] = "Tuổi KH";
            worksheet.Cells[3, 4] = "Số điện thoại KH";
            worksheet.Cells[3, 5] = "Địa chỉ khách hàng";
            worksheet.Cells[3, 6] = "CMND";
            worksheet.Cells[3, 7] = "Email";
           

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                worksheet.Cells[i + 4, 1] = i + 1;
                worksheet.Cells[i + 4, 2] = dataGridView1.Rows[i].Cells["makhDataGridViewTextBoxColumn"].Value;
                //Console.WriteLine(dgvHD.Rows[i].Cells["mahoadon"].Value);
                worksheet.Cells[i + 4, 3] = dataGridView1.Rows[i].Cells["tenkhDataGridViewTextBoxColumn"].Value;
                worksheet.Cells[i + 4, 4] = dataGridView1.Rows[i].Cells["tuoiDataGridViewTextBoxColumn"].Value;
                worksheet.Cells[i + 4, 5] = dataGridView1.Rows[i].Cells["sDTkhDataGridViewTextBoxColumn"].Value;
                worksheet.Cells[i + 4, 6] = dataGridView1.Rows[i].Cells["đCkhDataGridViewTextBoxColumn"].Value;
                worksheet.Cells[i + 4, 7] = dataGridView1.Rows[i].Cells["cMNDDataGridViewTextBoxColumn"].Value;
                worksheet.Cells[i + 4, 8] = dataGridView1.Rows[i].Cells["emailDataGridViewTextBoxColumn"].Value;
             
               
            }
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                timer1.Stop();
                if (result != null)
                {
                    txtQRCode.Text = result.ToString();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            if (txtQRCode.Text != null || txtQRCode.Text != "")
            {
                var dl = quanlichuan.Khachhangs.Where(s => s.Makh == txtQRCode.Text.Trim()).FirstOrDefault();
                txtten.Text = dl.Tenkh;
                txtsdt.Text = dl.SDTkh.ToString();
                txttuoi.Text = dl.Tuoi.ToString();
                txtcmnd.Text = dl.CMND.ToString();
                txtdiachi.Text = dl.ĐCkh.ToString();
                txtemail.Text = dl.Email.ToString();
                    

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
