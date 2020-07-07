using QL.data;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
          
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string s = txtThongTin.Text; txtThongTin.Text = s.Substring(1, s.Length - 1) + s[0];
            }
            catch { }
        }
        int x = 12, y = 15, a = -1;
        string manv="";
        private void dtnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            manv = dtnhanvien.CurrentRow.Cells[0].Value.ToString();
            
            txtten.Text = dtnhanvien.CurrentRow.Cells[1].Value.ToString();
            txtcmnd.Text = dtnhanvien.CurrentRow.Cells[2].Value.ToString();
            txtdiachi.Text = dtnhanvien.CurrentRow.Cells[3].Value.ToString();
            txtsdt.Text = dtnhanvien.CurrentRow.Cells[4].Value.ToString();
            if (e.ColumnIndex ==5)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà khách hàng không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
                    {
                        quanli.deletenv(manv);
                        MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        Form9_Load(sender, e);
                    }
                }
            }



        }
        //public bool KiemTraMa(string MaNV)
        //{
        //    string query = "select* from NhanVien";
        //    DataTable data = Connect.Instace.excutequery(query);
        //    int dem = 0;
        //    foreach (DataRow item in data.Rows)
        //    {
        //        dem++;
        //    }
        //    if (dem > 0)
        //        return true;
        //    return false;
        //}
        public bool kiemtra()
        {
            if ( txtten.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            {
                if (!kiemtra())
                {
                    return;
                }
                using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
                {
                    string manv = quanli.Nhanviens.Max(p=>p.MaNV);
                    string ma = manv.Substring(2, manv.Length - 2);
                    int manhanvien = int.Parse(ma) + 1;
                    if (manhanvien <= 9)
                        manv = "NV0" + manhanvien;
                    else
                        manv = "NV" + manhanvien;
                    Nhanvien nv = new Nhanvien();
                    nv.MaNV = manv;
                    nv.Hoten = txtten.Text;
                    nv.SĐT = txtsdt.Text;
                    nv.Diachi = txtdiachi.Text;
                    nv.CMND = int.Parse(txtcmnd.Text);
                    quanli.Nhanviens.Add(nv);
                    quanli.SaveChanges();

                    Form9_Load(sender, e);
                }
            }
        }
        private void gunaButton5_Click(object sender, EventArgs e)
        {
        }

            private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBCMBDataSet5.Nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter2.Fill(this.qLBCMBDataSet5.Nhanvien);



        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            {
                if (manv == "")
                {
                    MessageBox.Show("Hãy chọn nhân viên cần sửa!");
                    return;
                }
                using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
                {
                    Nhanvien nv = quanli.Nhanviens.FirstOrDefault(p => p.MaNV == manv);
                   
                    nv.Hoten = txtten.Text;
                    nv.SĐT = txtsdt.Text;
                    nv.Diachi = txtdiachi.Text;
                    nv.CMND = int.Parse(txtcmnd.Text);
                    quanli.SaveChanges();
                    MessageBox.Show("Sua thanh cong!");
                    Form9_Load(sender,e);
                }
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
            {
                dtnhanvien.DataSource = quanli.Nhanviens.Where(p => p.MaNV.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }

        Random random = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbchao.Location = new Point(x, y);
                if (x >= 415)
                {
                    a = -2;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 12)
                {
                    a = 2;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch (Exception)
            { }
        }
    }
}
