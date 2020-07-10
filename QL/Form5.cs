
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
    public partial class Form5 : Form
    {
        string MaTB;
        public Form5()
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
            DataTable table = new DataTable();
            table.Columns.Add("MaCB");
            table.Columns.Add("MaMB");
            table.Columns.Add("NgayBay");
            table.Columns.Add("ThoiGianBay");
            table.Columns.Add("GheLoai1");
            table.Columns.Add("GheLoai2");
            using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
            {
                List<Chuyenbay> ds_cb = quanli.Chuyenbays.ToList();
                foreach (var item in ds_cb)
                {
                    Maybay mb = quanli.Maybays.FirstOrDefault(p => p.MaMB == item.MaMB);
                    table.Rows.Add(item.MaCB, item.MaMB, item.Ngaybay, item.Thoigianbay, mb.Gheloai1, mb.Gheloai2);
                }
            }
            gunaDataGridView1.AutoGenerateColumns = false;
            gunaDataGridView1.DataSource = table;
        }

        private void dtchuyenbay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Form6 f = new Form6();
            f.Show();
            this.Close();
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

        private void gunaButton1_Click(object sender, EventArgs e)
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {

            Form11 f = new Form11();
            this.Hide();
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
            using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
            {
                quanli.deletecb(MaTB);
                quanli.SaveChanges();
                MessageBox.Show("đã xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                Form5_Load(sender, e);
            }
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            using (QLBCMBEntities1 quanli = new QLBCMBEntities1())
            {
                gunaDataGridView1.DataSource = quanli.Chuyenbays.Where(p => p.MaCB.Contains(gunaTextBox1.Text.Trim())).ToList();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
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
