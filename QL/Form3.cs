
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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            //Loadtt();
        }
        QLBCMBEntities3 dt = new QLBCMBEntities3();

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //DataTable data = new DataTable();
            //data.Columns.Add("MaCB");
            //data.Columns.Add("NgayBay");
            //data.Columns.Add("Thoigianbay");
            //data.Columns.Add("Giave");
            //data.Columns.Add("Hangve");
            //data.Columns.Add("Hangmb");

            cbDiemDi.ValueMember = "MaSb";
            cbDiemDi.DisplayMember = "TenSb";
            cbDiemDi.DataSource = dt.Sanbays.ToList();

            cbDiemDen.ValueMember = "MaSb";
            cbDiemDen.DisplayMember = "TenSb";
            cbDiemDen.DataSource = dt.Sanbays.ToList();

            cbLoaiVe.ValueMember = "Hang";
            cbLoaiVe.DisplayMember = "Hang";
            cbLoaiVe.DataSource = dt.Maybays.ToList();

            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "Hoten";
            cbnv.DataSource = dt.Nhanviens.ToList();

            cbkh.ValueMember = "Makh";
            cbkh.DisplayMember = "Tenkh";
            cbkh.DataSource = dt.Khachhangs.ToList();

            //cbmanv.ValueMember = "Hoten";
            //cbmanv.DisplayMember = "MaNV";
            //cbmanv.DataSource = dt.Nhanviens.ToList();

            //cbcmnd.ValueMember = "Makh";
            //cbcmnd.DisplayMember = "CMND";
            //cbcmnd.DataSource = dt.Khachhangs.ToList();
            //List<Hoadon> h = dt.Hoadons.ToList();
            //DataTable tb = new DataTable();


            //tb.Columns.Add("Nlap");
            //tb.Columns.Add("Tongtien");
            //tb.Columns.Add("Tinhtrang");
            //tb.Columns.Add("ThueVAT");
            //tb.Columns.Add("MaCB");
            //tb.Columns.Add("MaHD");
            //tb.Columns.Add("Mave");
            //tb.Columns.Add("Makh");
            //foreach (var item in h)
            //{
            //    tb.Rows.Add(item.Nlap, item.Tongtien , item.Tinhtrang , item.ThueVAT , item.MaCB , item.MaHD , item.Mave , item.Makh);
            //}
            //dataGridView2.DataSource = tb;




        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.TimKiemNangCao(cbDiemDi.SelectedValue.ToString(),
                                                            cbDiemDen.SelectedValue.ToString(),
                                                            cbLoaiVe.SelectedValue.ToString(),
                                                            Convert.ToDateTime(dtpNgayDi.Value));
            //dataGridView1.DataSource = dt.TimKiemNangCao(Convert.ToDateTime(dtpNgayDi.Value), cbDiemDi.SelectedValue.ToString(), cbDiemDen.SelectedValue.ToString(), cbLoaiVe.SelectedValue.ToString());
        }
        string macb = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbtensanden.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lbhangmaybay.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lbgioidi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            gunaLabel7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lnsanden.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void lbtensanden_Click(object sender, EventArgs e)
        {

        }

        private void lnsanden_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        int giave1;
        int giave2;
    
        private void txtI_TextChanged(object sender, EventArgs e)
        {
            int tongtien = 0;
            giave1 = 0;
            int giaveloai1;
            Chuyenbay chuyenbay = dt.Chuyenbays.Where(s => s.MaCB == label3.Text).FirstOrDefault();
            if (chuyenbay != null)
            {
                string a = chuyenbay.MaCB.ToString();
                Hoadon hoadon = dt.Hoadons.Where(s => s.MaCB == a.ToString()).FirstOrDefault();
                if (hoadon != null)
                {
                    string b = hoadon.MaHD.ToString();
                    CTVe cTVe = dt.CTVes.Where(s => s.MaHD == b.ToString()).FirstOrDefault();
                    if (cTVe != null)
                    {
                        string c = cTVe.Mave.ToString();
                        Ve ve = dt.Ves.Where(s => s.Mave == c.ToString()).FirstOrDefault();
                        giave1 = int.Parse(ve.Giave);
                        if (txtI.Text == "")
                        {
                            if (txtII.Text != "")
                            {
                                giaveloai1 = (giave2 * int.Parse(txtII.Text.Trim()) * 80) / 100;
                                tongtien = giaveloai1;
                                lbTongTien.Text = tongtien.ToString();
                            }
                            else
                            {
                                lbTongTien.Text = "0";
                            }
                            return;
                        }
                         giaveloai1 = giave1 * int.Parse(txtI.Text.Trim());
                         tongtien = int.Parse(lbTongTien.Text);
                         tongtien += giaveloai1;
                         lbTongTien.Text = tongtien.ToString();
                    
                            hoadon.Tongtien = tongtien;
                            dt.SaveChanges();
                            Form3_Load(sender, e);
                        
                    }
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            
                using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                {
                    Hoadon hd = new Hoadon();
                    hd.MaHD = txtmahd.Text;
                    hd.Nlap = DateTime.Now;
                    hd.MaNV = cbnv.SelectedValue.ToString();
                    hd.Makh = cbkh.SelectedValue.ToString();
                     hd.MaCB = dt.Chuyenbays.Where(s => s.MaCB == label3.Text).FirstOrDefault().MaCB; 
                    hd.Tongtien = int.Parse(lbTongTien.Text);
                    quanli.Hoadons.Add(hd);
                    quanli.SaveChanges();

                    if (String.IsNullOrEmpty(txtI.Text))
                    {
                        CTVe cT = new CTVe();
                        cT.MaHD = txtmahd.Text;
                        cT.Mave = "VE01";
                        cT.Soluongban = int.Parse(txtI.Text);
                        quanli.CTVes.Add(cT);
                        quanli.SaveChanges();
                    }
                    if (String.IsNullOrEmpty(txtII.Text))
                    {
                        CTVe cT = new CTVe();
                        cT.MaHD = txtmahd.Text;
                        cT.Mave = "VE02";
                        cT.Soluongban = int.Parse(txtI.Text);
                        quanli.CTVes.Add(cT);
                        quanli.SaveChanges();
                    }
                MessageBox.Show("Thêm thành công");

                }
            
            
            

            //    //dt.themhd(cbnv.SelectedValue.ToString(), Convert.ToDateTime(dtngaylap.Text), int.Parse(lbTongTien.Text), comboBox3.SelectedValue.ToString(), int.Parse(textBox1.Text), textBox2.Text, cbcb.SelectedValue.ToString(), cbmakh.SelectedValue.ToString());

            //}
            //    Chuyenbay chuyenbay = dt.Chuyenbays.Where(s => s.MaCB == label3.Text.Trim()).FirstOrDefault();
            //    Hoadon hoadon = dt.Hoadons.Where(s => s.MaCB == chuyenbay.MaCB.ToString()).FirstOrDefault();
            //    CTVe cTVe = dt.CTVes.Where(s => s.MaHD == hoadon.MaHD.ToString()).FirstOrDefault();
            //    Ve ve = dt.Ves.Where(s => s.Mave == cTVe.Mave.ToString()).FirstOrDefault();
            //    giave = Convert.ToDouble(ve.Giave) ;
            //    lbTongTien2.Text = giave.ToString();
            int giaveloai1, giaveloai2;
            if (txtI.Text != "" && txtII.Text != "")
            {
                giaveloai1 = int.Parse(txtI.Text)*giave1;
                giaveloai2 = int.Parse(txtII.Text) * giave2;
                int tong = giaveloai1 + giaveloai2;
                lbTongTien.Text = tong.ToString();
            }
        }

        private void dtngaylap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtngaylap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void txtII_TextChanged(object sender, EventArgs e)
        {
            QLBCMBEntities3 dt = new QLBCMBEntities3();
            giave2 = 0;
            int giaveloai2, tongtien;
            Chuyenbay chuyenbay = dt.Chuyenbays.Where(s => s.MaCB == label3.Text).FirstOrDefault();
            if (chuyenbay != null)
            {
                string a = chuyenbay.MaCB.ToString();
                Hoadon hoadon = dt.Hoadons.Where(s => s.MaCB == a.ToString()).FirstOrDefault();
                if (hoadon != null)
                {
                    string b = hoadon.MaHD.ToString();
                    CTVe cTVe = dt.CTVes.Where(s => s.MaHD == b.ToString()).FirstOrDefault();
                    if (cTVe != null)
                    {
                        string c = cTVe.Mave.ToString();
                        Ve ve = dt.Ves.Where(s => s.Mave == c.ToString()).FirstOrDefault();
                        giave2 = int.Parse(ve.Giave);
                        if (txtII.Text == "")
                        {
                            if (txtI.Text != "")
                            {
                                giaveloai2 = giave1 * int.Parse(txtI.Text.Trim());
                                tongtien = giaveloai2;
                                lbTongTien.Text = tongtien.ToString();
                            }
                            else
                            {
                                lbTongTien.Text = "0";
                            }
                            return;
                        }                 
                        giaveloai2 = (giave2 * int.Parse(txtII.Text.Trim()))*80/100;
                        tongtien = int.Parse(lbTongTien.Text);
                        tongtien += giaveloai2;
                        lbTongTien.Text = tongtien.ToString();
                        hoadon.Tongtien = tongtien;
                        //hoadon.MaNV = txtmahd.Text; 
                        dt.SaveChanges();
                        Form3_Load(sender, e);
                    }
                }

            }
        }
    }
}


