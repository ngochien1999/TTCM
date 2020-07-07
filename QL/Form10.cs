using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL.QLBCMBDataSet4TableAdapters;
using QL.data;

namespace QL
{
    public partial class Form10 : Form
    {
        public Form10()
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

        }
        string mamb = "";
        private void dtmaybay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            mamb = dtmaybay.CurrentRow.Cells[0].Value.ToString();

            txtten.Text = dtmaybay.CurrentRow.Cells[1].Value.ToString();
            cbGT.Text = dtmaybay.CurrentRow.Cells[2].Value.ToString();
            txtI.Text = dtmaybay.CurrentRow.Cells[3].Value.ToString();
            txtII.Text = dtmaybay.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
            {
                dtmaybay.DataSource = quanli.Maybays.Where(p => p.MaMB.Contains(txttimkiem.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
            {

                quanli.deletemb(mamb);
                quanli.SaveChanges();
                MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form10_Load(sender, e);
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
            {
                if (!kiemtra())
                {
                    return;
                }
                using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
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
                    nv.Gheloai2 =txtII.Text;
                    quanli.Maybays.Add(nv);
                    quanli.SaveChanges();

                    Form10_Load(sender, e);
                }
            }
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

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbchao.Location = new Point(x, y);
                if (x >= 178)
                {
                    a = -2;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 11)
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



