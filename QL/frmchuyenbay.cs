
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
    public partial class frmchuyenbay : Form
    {
        string MaTB="";
        public frmchuyenbay()
        {
            InitializeComponent();
            //Loadchuyenbay();
            //LoadCombox();
            //cbdi.SelectedIndex = -1;
        }
        //public void Loadchuyenbay()
        //{
        //    string query = " select * from Tuyenbay";
        //    DataTable data = Connect.Instace.excutequery(query);
        //   dtchuyenbay.DataSource = data;

        //}
      //public void LoadCombox()
      //  {
      //      string query = "select * from Tuyenbay";
      //      DataTable data = Connect.Instace.excutequery(query);
      //      cbdi.DataSource = data;
      //      cbdi.ValueMember = "MaTB";
      //      cbdi.DisplayMember = "SBdi";
      //  }
        private void Form5_Load(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                dataGridView1.DataSource = quanli.them();
            }
            DSBItems();

            //DataTable table = new DataTable();
            ////table.Columns.Add("MaCB");
            ////table.Columns.Add("MaMB");
            ////table.Columns.Add("NgayBay");
            ////table.Columns.Add("ThoiGianBay");
            ////table.Columns.Add("GheLoai1");
            ////table.Columns.Add("GheLoai2");
            //using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            //{

            //    List<Chuyenbay> ds_cb = quanli.Chuyenbays.ToList();
            //    foreach (var item in ds_cb)
            //    {
            //        Maybay mb = quanli.Maybays.FirstOrDefault(p => p.MaMB == item.MaMB);
            //        table.Rows.Add(item.MaCB, item.MaMB, item.Ngaybay, item.Thoigianbay, mb.Gheloai1, mb.Gheloai2);
            //    }
            //}
            //gunaDataGridView1.AutoGenerateColumns = false;
            //gunaDataGridView1.DataSource = table;
        }
        private void clearData()
        {
            txtdiachi.Text = "";
            txtngaybay.Text = "";
            txtsanbayden.Text = "";
            txtsbd.Text = "";
            txtsoluongii.Text = "";
            txtthoigianbay.Text = "";



        }
        private void DSBItems()
        {
            btnluu.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = false;
            txtdiachi.Enabled = false;
            txtngaybay.Enabled = false;
            txtsanbayden.Enabled = false;
            txtsbd.Enabled = false;
            txtsoluongii.Enabled = false;
            txtthoigianbay.Enabled = false;


        }
        private void EnableItem()
        {
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtdiachi.Enabled = true;
            txtngaybay.Enabled = true;
            txtsanbayden.Enabled = true;
            txtsbd.Enabled = true;
            txtsoluongii.Enabled = true;
            txtthoigianbay.Enabled = true;


        }

        private void dtchuyenbay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Form6 f = new Form6();
            //f.Show();
            //this.Close();
        }

        private void dtchuyenbay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void progressPanel1_Click(object sender, EventArgs e)
        {

        }

        private void closeForm(object sender, EventArgs e)
        {
            Form5_Load(sender, e);
            this.Visible = true;
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

        }
        private bool temp;
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            btnthen.Enabled = false;
            btnsua.Enabled = false;
            clearData();
            dataGridView1.Enabled = false;
            EnableItem();
            temp = true;
           
                    frmthemthongtincb f = new frmthemthongtincb();
                    f.Visible = true;
                    f.getLuu().Click += closeForm;
                    f.Show();
                
            

        }


        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int x = 15, y = 15, a = 1;

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {

        }
       
        private void gunaButton1_Click_2(object sender, EventArgs e)
        {
            DSBItems();
            clearData();
            btnthen.Enabled = true;
            dataGridView1.Enabled = true;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                dataGridView1.DataSource = quanli.Chuyenbays.Where(p => p.MaCB.Contains(gunaTextBox1.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MaTB = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtngaybay.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtthoigianbay.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtsanbayden.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtsbd.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtdiachi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                txtsoluongii.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                btnsua.Enabled = true;

            }
            catch
            {
                btnsua.Enabled = false;
            }





        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            temp = false;
            EnableItem();
            dataGridView1.Enabled = false;
            btnthen.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    x += a;
            //    lbchao.Location = new Point(x, y);
            //    if (x >= 320)
            //    {
            //        a = -1;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //    if (x <= 15)
            //    {
            //        a = 1;
            //        lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }
    }
}
