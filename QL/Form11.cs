using Guna.UI.WinForms;

using QL.DataSet2TableAdapters;
using QL.QLBCMBDataSet6TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace QL
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        QLBCMBEntities3 quanlichuan = new QLBCMBEntities3();

        private void Form11_Load(object sender, EventArgs e)
        {
            //cbMayBay.DisplayMember = "TenMB";
            //cbMayBay.ValueMember = "MaMB";
            //cbMayBay.DataSource = quanlichuan.Maybays.ToList();

            cbdi.DisplayMember = "TenSb";
            cbdi.ValueMember = "MaSb";
            cbdi.DataSource = quanlichuan.Sanbays.ToList();

            cbden.DisplayMember = "TenSb";
            cbden.ValueMember = "MaSb";
            cbden.DataSource = quanlichuan.Sanbays.ToList();

            cbTrungGian.DisplayMember = "TenSb";
            cbTrungGian.ValueMember = "MaSb";
            cbTrungGian.DataSource = quanlichuan.Sanbays.ToList();
        }

        private void cbMayBay_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        public GunaButton getLuu()
        {
            return gunaButton1;
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            //{
            //    Chuyenbay cb = new Chuyenbay(); ;
            //    string macb = quanli.Chuyenbays.Max(p => p.MaCB);
            //    macb = macb.Substring(2, macb.Length - 2);
            //    if (int.Parse(macb) < 9)
            //        macb = "CB0" + (int.Parse(macb) + 1);
            //    else
            //        macb = "CB" + (int.Parse(macb) + 1);
            //    cb.MaCB = macb;
            //    cb.Ngaybay = dtngay.Value;

            //    var mb = quanli.Maybays.Where(s => s.MaMB == cbMayBay.SelectedValue.ToString()).FirstOrDefault();
            //    cb.MaMB = mb.TenMB;
            //    TimeSpan time = TimeSpan.Parse(tbgiobay.Text);
            //    cb.Thoigianbay = time;
            //    quanli.Chuyenbays.Add(cb);
            //    quanli.SaveChanges();

            //    CTchuyenbay ct = new CTchuyenbay(); ;
            //    string matb = quanli.CTchuyenbays.Max(p => p.MaTB);
            //    matb = matb.Substring(2, matb.Length - 2);
            //    if (int.Parse(matb) < 9)
            //        matb = "TB0" + (int.Parse(matb) + 1);
            //    else
            //        matb = "TB" + (int.Parse(matb) + 1);
            //    ct.MaCB = macb;
            //    ct.MaTB = matb;
            //    TimeSpan time1 = TimeSpan.Parse(dtThoiGiandung.Text);
            //    ct.Thoigiandung = time;
            //    ct.SBtrunggian = cbTrungGian.SelectedValue.ToString();
            //    quanli.CTchuyenbays.Add(ct);
            //    quanli.SaveChanges();

            //    Tuyenbay tb = new Tuyenbay();
            //    tb.MaTB = matb;
            //    tb.SBdi = cbdi.SelectedValue.ToString();
            //    tb.SBden = cbden.SelectedValue.ToString();
            //    quanli.Tuyenbays.Add(tb);
            //    quanli.SaveChanges();

            //    MessageBox.Show("Da them");

            //}
            //Chuyenbay cb = new Chuyenbay();
            //string macb = quanlichuan.Chuyenbays.Max(p => p.MaCB);
            //macb = macb.Substring(2, macb.Length - 2);
            //if (int.Parse(macb) < 9)
            //    macb = "CB0" + (int.Parse(macb) + 1);
            //else
            //    macb = "CB" + (int.Parse(macb) + 1);
            //cb.MaCB = macb;



            //string mamb = quanlichuan.Chuyenbays.Max(p => p.MaMB);
            //mamb = mamb.Substring(2, mamb.Length - 2);
            //if (int.Parse(mamb) < 9)
            //    mamb = "MB0" + (int.Parse(mamb) + 1);
            //else
            //    mamb = "MB" + (int.Parse(mamb) + 1);
            //cb.MaMB = mamb;




            //CTchuyenbay ct = new CTchuyenbay();
            //string matb = quanlichuan.CTchuyenbays.Max(p => p.MaTB);
            //matb = matb.Substring(2, macb.Length - 2);
            //if (int.Parse(matb) < 9)
            //    matb = "TB" + (int.Parse(matb) + 1);
            //else
            //    matb = "TB0" + (int.Parse(matb) + 1);
            //ct.MaTB = matb;





            quanlichuan.chuyenbay_ha(txtma.Text, txtmac.Text, Convert.ToDateTime(dtngay.Text), TimeSpan.Parse(tbgiobay.Text), cbden.SelectedValue.ToString(), cbdi.SelectedValue.ToString(), int.Parse(txtI.Text), int.Parse(txtII.Text), txttuyen.Text, TimeSpan.Parse(dtThoiGiandung.Text), cbTrungGian.SelectedValue.ToString() );
            MessageBox.Show("Đã thêm thành công");


            //quanlichuan.ThemDuLieu(txtma.Text.Trim(), Convert.ToDateTime(dtngay.Value),
            //    TimeSpan.Parse(tbgiobay.Text), txtmatb.Text.Trim(), TimeSpan.Parse(dtThoiGiandung.Text)
            //    , cbTrungGian.SelectedValue.ToString(), cbdi.SelectedValue.ToString(), cbden.SelectedValue.ToString(),
            //    cbMayBay.SelectedValue.ToString());

            //MessageBox.Show("Đã thêm thành công !!!");
            Form5 f = new Form5();
            f.Show();
            this.Close();
        }

        private void cbMayBay_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Form2 f = ;
            this.Hide();
            //f.ShowDialog();
            //this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
