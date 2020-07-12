

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
    public partial class Form12 : Form
    {
        QLBCMBEntities3 quanlichuan = new QLBCMBEntities3();
        public Form12()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            {
                if (!kiemtra())
                {
                    return;
                }
                else
                {
                    string masb = quanlichuan.Sanbays.Max(p => p.MaSb);
                    string ma = masb.Substring(2, masb.Length - 2);
                    int manhanvien = int.Parse(ma) + 1;
                    if (manhanvien <= 9)
                        masb = "SB0" + manhanvien;
                    else
                        masb = "SB" + manhanvien;
                    Sanbay nv = new Sanbay();
                    nv.MaSb = masb;
                    nv.TenSb = txtten.Text;
                    nv.Diachi = txtdiachi.Text;

                    quanlichuan.Sanbays.Add(nv);
                    quanlichuan.SaveChanges();

                    Form12_Load(sender, e);
                }
            }
        }
        int x = 9, y = 17, a = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    x += a;
            //    lbchao.Location = new Point(x, y);
            //    if (x >= 416)
            //    {
            //        a = -1;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //    if (x <= 9)
            //    {
            //        a = 1;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }

            //}
            //catch (Exception)
            //{ }
        }
        string masb = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        Random random = new Random();

        private void gunaButton2_Click(object sender, EventArgs e)
        {
                quanlichuan.deletesb(txtma.Text.Trim());
                DialogResult dr =  MessageBox.Show("đã xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Form12_Load(sender, e);
                }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            {
                if (masb == "")
                {
                    MessageBox.Show("Hãy chọn sân bay cần sửa!");
                    return;
                }
                   Sanbay nv = quanlichuan.Sanbays.FirstOrDefault(p => p.MaSb == masb);

                    nv.TenSb = txtten.Text;
                    nv.Diachi = txtdiachi.Text;
                   
                    quanlichuan.SaveChanges();
                DialogResult dr = MessageBox.Show("Sua thanh cong!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    Form12_Load(sender, e);
                }
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                dataGridView1.DataSource = quanli.Sanbays.Where(p => p.MaSb.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            masb = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtdiachi.Text = "";
            txtten.Text = "";
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = quanlichuan.Sanbays.ToList();

        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || txtdiachi.Text == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
    }
}
