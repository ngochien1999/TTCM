
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
    public partial class frmve : Form
    {

        public frmve()
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


            cbkh.ValueMember = "Makh";
            cbkh.DisplayMember = "Tenkh";
            cbkh.DataSource = dt.Khachhangs.ToList();

            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "Hoten";
            cbnv.DataSource = dt.Nhanviens.ToList();

            

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
            cbnv.SelectedValue = frmLogin.ttnv.manv;
            cbnv.Enabled = false;




        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
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
                Ve ve1 = dt.Ves.Where(s => s.MaCB == a.ToString()).FirstOrDefault();
                if (ve1 != null)
                {
                    giave1 = int.Parse(ve1.Giave);
                    giave1 = int.Parse(ve1.Giave);
                }
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
                        dt.SaveChanges();
                        Form3_Load(sender, e);                    
                
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            

                using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
                {
                //    Hoadon hd = new Hoadon();
                //    hd.MaHD = txtmahd.Text;
                //    hd.Nlap = DateTime.Now;
                //    hd.MaNV = cbnv.SelectedValue.ToString();
                //    hd.Makh = cbkh.SelectedValue.ToString();
                //    hd.MaCB = label3.Text;
                //hd.Tongtien = int.Parse(lbTongTien.Text);
                //quanli.Hoadons.Add(hd);
                //quanli.SaveChanges();
               // quanli.mahoadon(cbnv.SelectedValue, Convert.ToDateTime(dtngay.Text), lbTongTien.Text, cbkh.SelectedValue);
                quanli.themHoaDon( cbnv.SelectedValue.ToString()
                    , int.Parse(lbTongTien.Text), cbkh.SelectedValue.ToString(), DateTime.Now, textBox1.Text);
                CTVe ct = new CTVe();
                ct.MaHD = quanli.Hoadons.Max(p => p.MaHD);
                ct.Mave = textBox1.Text;
                quanli.CTVes.Add(ct);
                int n = int.Parse(txtI.Text) + int.Parse(txtII.Text);

                ct.Soluongban = n;

                quanli.SaveChanges();

                //if (String.IsNullOrEmpty(txtI.Text))
                //{
                //    CTVe cT = new CTVe();
                //    cT.MaHD = txtmahd.Text;
                //    cT.Mave = "V01";
                //    cT.Soluongban = int.Parse(txtI.Text);
                //    quanli.CTVes.Add(cT);
                //    quanli.SaveChanges();
                //}
                //if (String.IsNullOrEmpty(txtII.Text))
                //{
                //    CTVe cT = new CTVe();
                //    cT.MaHD = txtmahd.Text;
                //    cT.Mave = "V02";
                //    cT.Soluongban = int.Parse(txtI.Text);
                //    quanli.CTVes.Add(cT);
                //    quanli.SaveChanges();
                //}
                MessageBox.Show("Thêm thành công");

                }
            int giaveloai1, giaveloai2;
            if (txtI.Text != "" && txtII.Text != "")
            {
                giaveloai1 = int.Parse(txtI.Text) * giave1;
                giaveloai2 = int.Parse(txtII.Text) * giave2;
                int tong = giaveloai1 + giaveloai2;
                lbTongTien.Text = tong.ToString();
            }




            //    //dt.themhd(cbnv.SelectedValue.ToString(), Convert.ToDateTime(dtngaylap.Text), int.Parse(lbTongTien.Text), comboBox3.SelectedValue.ToString(), int.Parse(textBox1.Text), textBox2.Text, cbcb.SelectedValue.ToString(), cbmakh.SelectedValue.ToString());

            //}
            //Chuyenbay chuyenbay = dt.Chuyenbays.Where(s => s.MaCB == label3.Text.Trim()).FirstOrDefault();
            //Hoadon hoadon = dt.Hoadons.Where(s => s.MaCB == chuyenbay.MaCB.ToString()).FirstOrDefault();
            //CTVe cTVe = dt.CTVes.Where(s => s.MaHD == hoadon.MaHD.ToString()).FirstOrDefault();
            //Ve ve = dt.Ves.Where(s => s.Mave == cTVe.Mave.ToString()).FirstOrDefault();
            //giave = int.Parse(ve.Giave);
            //lbTongTien.Text = giave.ToString();
            //giave = Convert.ToDouble(ve.Giave);
            //lbTongtien.Text = giave.ToString();


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
                Ve ve1 = dt.Ves.Where(s => s.MaCB == a.ToString()).FirstOrDefault();
               
                        giave2 = int.Parse(ve1.Giave);
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
                        giaveloai2 = (giave2 * int.Parse(txtII.Text.Trim())) * 80 / 100;
                        tongtien = int.Parse(lbTongTien.Text);
                        tongtien += giaveloai2;
                        lbTongTien.Text = tongtien.ToString();
                       // hoadon.Tongtien = tongtien;
                        //hoadon.MaNV = txtmahd.Text; 
                        dt.SaveChanges();
                        Form3_Load(sender, e);
                    
                

            }
        }

        private void cbDiemDi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label4.Text = cbnv.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmkhachhang f = new frmkhachhang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string a = "";
            using(QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                a = quanli.Hoadons.Max(p => p.MaHD);
               
            }    
            frminhoadon f = new frminhoadon(a);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dt.TimKiemNangCao(cbDiemDi.SelectedValue.ToString(),
                                                            cbDiemDen.SelectedValue.ToString(),
                                                            cbLoaiVe.SelectedValue.ToString(),
                                                            Convert.ToDateTime(dtpNgayDi.Value));
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}


