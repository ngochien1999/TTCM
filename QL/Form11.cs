using Guna.UI.WinForms;
using QL.data;
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
        string macb;

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'duLieu.Maybay' table. You can move, or remove it, as needed.
            this.maybayTableAdapter.Fill(this.duLieu.Maybay);
            // TODO: This line of code loads data into the 'duLieu.Sanbay' table. You can move, or remove it, as needed.
            this.sanbayTableAdapter.Fill(this.duLieu.Sanbay);
           

        }
        public GunaButton getLuu()
        {
            return gunaButton1;
        }
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
            {
                Chuyenbay cb = new Chuyenbay(); ;
                string macb = quanli.Chuyenbays.Max(p => p.MaCB);
                macb = macb.Substring(2, macb.Length - 2);
                if (int.Parse(macb) < 9)
                    macb = "CB0" + (int.Parse(macb) + 1);
                else
                    macb = "CB" + (int.Parse(macb) + 1);
                cb.MaCB = macb;
                cb.Ngaybay = dtngay.Value;
                cb.MaMB = cbMayBay.SelectedValue.ToString();
                TimeSpan time = TimeSpan.Parse(tbgiobay.Text);
                cb.Thoigianbay = time;
                quanli.Chuyenbays.Add(cb);
                quanli.SaveChanges();
                CTchuyenbay ct = new CTchuyenbay(); ;
                string matb = quanli.CTchuyenbays.Max(p => p.MaTB);
                matb = matb.Substring(2, matb.Length - 2);
                if (int.Parse(matb) < 9)
                    matb = "TB0" + (int.Parse(matb) + 1);
                else
                    matb = "TB" + (int.Parse(matb) + 1);
                ct.MaCB = macb;
                ct.MaTB = matb;
                TimeSpan time1 = TimeSpan.Parse(dtThoiGiandung.Text);
                ct.Thoigiandung = time;
                ct.SBtrunggian = cbTrungGian.SelectedValue.ToString();
                quanli.CTchuyenbays.Add(ct);
                quanli.SaveChanges();
                Tuyenbay tb = new Tuyenbay();
                tb.MaTB = matb;
                tb.SBdi = cbdi.SelectedValue.ToString();
                tb.SBden = cbden.SelectedValue.ToString();
                quanli.Tuyenbays.Add(tb);
                quanli.SaveChanges();
                MessageBox.Show("Da them");

            }
            this.Close();
        }
    }
}
