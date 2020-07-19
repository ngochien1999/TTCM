

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

    public partial class frmsanbay : Form
    {
        QLBCMBEntities3 quanlichuan = new QLBCMBEntities3();
        public frmsanbay()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            btnthen.Enabled = false;
            btnsua.Enabled = false;
            clearData();
            dataGridView1.Enabled = false;
            EnableItem();
            temp = true;
        }
        int x = 9, y = 17, a = 1;
        private void clearData()
        {
            txtten.Text = "";
            txtdiachi.Text = "";
            txtma.Text = "";
           

        }
        private void DSBItems()
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            txtten.Enabled = false;
            txtma.Enabled = false;
            txtdiachi.Enabled = false;
           


        }
        private void EnableItem()
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtten.Enabled = true;
            txtdiachi.Enabled = true;
            txtma.Enabled = true;
         


        }

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
               
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            quanlichuan.deletesb(txtma.Text.Trim());
            DialogResult dr = MessageBox.Show("đã xóa", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                Form12_Load(sender, e);
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
            try
            {
                txtma.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtdiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                masb = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                btnsua.Enabled = true;
            }
            catch
            {
                btnsua.Enabled = false;
            }
            
        }
        private bool temp;
        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            {
                if (temp)
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
                            btnthen.Enabled = true;
                            dataGridView1.Enabled = true;

                            Form12_Load(sender, e);
                            clearData();
                        }
                    }
                }
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
                    DialogResult dr = MessageBox.Show("Sửa thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Form12_Load(sender, e);
                        btnthen.Enabled = true;
                        dataGridView1.Enabled = true;
                        clearData();
                    }
                }
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            temp = false;
            EnableItem();
            dataGridView1.Enabled = false;
            btnthen.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DSBItems();
            clearData();
            btnthen.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = quanlichuan.Sanbays.ToList();
            DSBItems();

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
