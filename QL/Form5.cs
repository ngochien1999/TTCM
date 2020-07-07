using QL.data;
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
            using (QLBCMBEntities2 quanli = new QLBCMBEntities2())
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
            this.Hide();
            f.ShowDialog();
            this.Show();
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

            Form11 f = new Form11();
            this.Hide();
            f.getLuu().Click += closeForm;
            f.ShowDialog();
        }

        private void closeForm(object sender, EventArgs e)
        {
            Form5_Load(sender, e);
            this.Visible = true;
        }
    }
}
