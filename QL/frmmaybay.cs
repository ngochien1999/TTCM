using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace QL
{
    public partial class frmmaybay : Form
    {
        private void clearData()
        {
            txtten.Text = "";
            txtI.Text = "";
            txtII.Text = "";
            
           cbGT.SelectedIndex = -1;
        }
        private void DSBItems()
        {
            btnLuu.Enabled = false;
            btnsua.Enabled = false;
            btnHuy.Enabled = false;
            txtten.Enabled = false;
            txtI.Enabled = false;
            txtII.Enabled = false;

            cbGT.Enabled = false;
        
        }
        private void EnableItem()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtten.Enabled = true;
            txtI.Enabled = true;
            txtII.Enabled = true;
            cbGT.Enabled = true;
        
        }
        public frmmaybay()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBCMBDataSet10.Maybay' table. You can move, or remove it, as needed.
            this.maybayTableAdapter2.Fill(this.qLBCMBDataSet10.Maybay);
            // TODO: This line of code loads data into the 'qLBCMBDataSet9.Maybay' table. You can move, or remove it, as needed.
            this.maybayTableAdapter1.Fill(this.qLBCMBDataSet9.Maybay);
            // TODO: This line of code loads data into the 'qLBCMBDataSet8.Maybay' table. You can move, or remove it, as needed.
            this.maybayTableAdapter.Fill(this.qLBCMBDataSet8.Maybay);
            DSBItems();


        }
        string mamb = "";
        private void dtmaybay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
                {
                mamb = dtmaybay.CurrentRow.Cells[0].Value.ToString();

                txtten.Text = dtmaybay.CurrentRow.Cells[1].Value.ToString();
                cbGT.Text = dtmaybay.CurrentRow.Cells[2].Value.ToString();
                txtI.Text = dtmaybay.CurrentRow.Cells[3].Value.ToString();
                txtII.Text = dtmaybay.CurrentRow.Cells[4].Value.ToString();
                btnsua.Enabled = true;
            }
            catch
            {
                btnsua.Enabled = false;
            }



            if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhà khách hàng không ?", "xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                    {
                        quanli.deletemb(mamb);
                        quanli.SaveChanges();
                        MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        Form10_Load(sender, e);
                    }
                }
            }

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                dtmaybay.DataSource = quanli.Maybays.Where(p => p.MaMB.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                {
                    Maybay hd = quanli.Maybays.FirstOrDefault(p => p.MaMB == mamb);
                    if (hd != null)
                    {
                        quanli.Maybays.Remove(hd);
                        quanli.SaveChanges();
                        MessageBox.Show("Đã xóa!");
                        Form10_Load(sender, e);
                    }
                }
            }
        }
        public bool kiemtra()
        {
            if (txtten.Text == "" || cbGT.Text == "" || txtI.Text == "" || txtII.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return false;
            }
            else
                return true;
        }
        private void gunaButton6_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            clearData();
            dtmaybay.Enabled = false;
            EnableItem();
            temp = true;
        }
        int x = 11, y = 31, a = -1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string s = txtThongTin.Text; txtThongTin.Text = s.Substring(1, s.Length - 1) + s[0];
            }
            catch { }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            temp = false;
            EnableItem();
            dtmaybay.Enabled = false;
            btnthem.Enabled = false;
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            {
                if (temp)
                {
                    if (!kiemtra())
                    {
                        return;
                    }
                   
                    using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                    {
                        string mamb = quanli.Maybays.Max(p => p.MaMB);
                        string ma = mamb.Substring(2, mamb.Length - 2);
                        int manhanvien = int.Parse(ma) + 1;
                        if (manhanvien <= 9)
                            mamb = "MB0" + manhanvien;
                        else
                            mamb = "MB" + manhanvien;
                        Maybay nv = new Maybay();
                        nv.MaMB = mamb;
                        nv.TenMB = txtten.Text;
                        nv.Hang = cbGT.Text;
                        nv.Gheloai1 = txtI.Text;
                        nv.Gheloai2 = txtII.Text;

                        quanli.Maybays.Add(nv);
                        quanli.SaveChanges();

                        Form10_Load(sender, e);
                        clearData();
                        btnthem.Enabled = true;
                        dtmaybay.Enabled = true;
                    }
                }



                else
                {
                    if (mamb == "")
                    {
                        MessageBox.Show("Hãy chọn máy bay cần sửa!");
                        return;
                    }
                    {
                        using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                        {

                            if (mamb == "")
                            {
                                MessageBox.Show("Hãy chọn sân bay cần sửa!");
                                return;
                            }

                            using (QLBCMBEntities3 quanli1 = new QLBCMBEntities3())
                            {
                                Maybay nv = quanli1.Maybays.FirstOrDefault(p => p.MaMB == mamb);

                                nv.TenMB = txtten.Text;
                                nv.Hang = cbGT.Text;
                                nv.Gheloai1 = txtI.Text;
                                nv.Gheloai2 = txtII.Text;

                                quanli1.SaveChanges();
                                DialogResult dr = MessageBox.Show("Sửa thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form10_Load(sender, e);
                                clearData();
                                btnthem.Enabled = true;
                                dtmaybay.Enabled = true;
                            }





                        }
                    }
                }



            }
        }
        private bool temp;

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSBItems();
            clearData();
            btnthem.Enabled = true;
            dtmaybay.Enabled = true;
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    x += a;
            //    lbchao.Location = new Point(x, y);
            //    if (x >= 178)
            //    {
            //        a = -2;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //    if (x <= 11)
            //    {
            //        a = 2;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }

            //}
            //catch (Exception)
            //{ }
        }
    }
}



