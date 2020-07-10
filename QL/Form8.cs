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
        QLBCMBEntities1 quanlichuan = new QLBCMBEntities1();
        public Form8()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBCMBDataSet13.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBCMBDataSet13.Khachhang);


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
            makh = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttuoi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtcmnd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            {
                if (!kiemtra())
                {
                    return;
                }
                using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
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
                }
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
            {
                quanli.deletekh(makh);
                quanli.SaveChanges();
                MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form8_Load(sender, e);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            {
                if (makh == "")
                {
                    MessageBox.Show("Hãy chọn khách hàng cần sửa!");
                    return;
                }
                using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
            {
                dataGridView1.DataSource = quanli.Khachhangs.Where(p => p.Makh.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }
    }
}
