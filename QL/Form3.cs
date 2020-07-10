
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
        QLBCMBEntities1 dt = new QLBCMBEntities1();
       
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

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.TimKiemNangCao(   cbDiemDi.SelectedValue.ToString(),
                                                            cbDiemDen.SelectedValue.ToString(),
                                                            cbLoaiVe.SelectedValue.ToString() ,
                                                            Convert.ToDateTime(dtpNgayDi.Value));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
