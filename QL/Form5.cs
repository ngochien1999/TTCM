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
        public Form5()
        {
            InitializeComponent();
           
       
        }
       
        private void Form5_Load(object sender, EventArgs e)
        {
            customerBindingSource.Add(new Customer() { Matuyenbay = "TB01", Sanbaydi = "Buôn Ma Thuột", Sanbayden = "Hồ Chí Minh" });
            customerBindingSource.Add(new Customer() { Matuyenbay = "TB02", Sanbaydi = "Đà Nẵng", Sanbayden = "Quy Nhơn" });
            customerBindingSource.Add(new Customer() { Matuyenbay = "TB03", Sanbaydi = "Nha Trang", Sanbayden = "Vân Đồn" });
            customerBindingSource.Add(new Customer() { Matuyenbay = "TB04", Sanbaydi = "Phú Quốc", Sanbayden = "Hồ Chí Minh" });
        }

        private void dttb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      

        private void dttb_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dttb.CurrentRow.Index;
            txtma.Text = dttb.Rows[i].Cells[0].Value.ToString();
            cbdi.Text = dttb.Rows[i].Cells[1].Value.ToString();
            cbden.Text = dttb.Rows[i].Cells[2].Value.ToString();
            if (dttb.Columns[e.ColumnIndex].Name == "Xemchitiet")
            {
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }    
        }

        private void dttb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
