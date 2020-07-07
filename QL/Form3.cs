using QL.QLBCMBDataSetTableAdapters;
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
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {

            Form4 f = new Form4();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        public void thongTinChuyenBay(string gv)
        {
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'qLBCMBDataSet1.Chuyenbay' table. You can move, or remove it, as needed.
            // this.chuyenbayTableAdapter.Fill(this.qLBCMBDataSet1.Chuyenbay);
            // TODO: This line of code loads data into the 'qLBCMBDataSet.Tuyenbay' table. You can move, or remove it, as needed.
            // this.tuyenbayTableAdapter.Fill(this.qLBCMBDataSet.Tuyenbay);
            // TODO: This line of code loads data into the 'qLBCMBDataSet2.Ve' table. You can move, or remove it, as needed.
            //this.veTableAdapter.Fill(this.qLBCMBDataSet2.Ve);
            // TODO: This line of code loads data into the 'qLBCMBDataSet2.Chuyenbay' table. You can move, or remove it, as needed.
            // this.chuyenbayTableAdapter.Fill(this.qLBCMBDataSet2.Chuyenbay);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TableAdapterManager tt = new TableAdapterManager();
            DataTable table = new DataTable();
           tt.Fill(table, cbDiemDi.SelectedValue.ToString(), cbDiemDen.SelectedValue.ToString(), dtpNgayDi.Value, cbLoaiVe.Text);
            dataGridView1.DataSource = table;
        }

        private void cbDiemDi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
