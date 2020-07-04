using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL
{
    public partial class Sanbay : Form
    {
        
       
        public Sanbay()
        {
            InitializeComponent();
            Load();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
     
        }
         public void Load()
        {
            string query = " select * from SanBay";
            DataTable data = Connect.Instace.excutequery(query);
            dtsanbay.DataSource = data;
            
        }
        public bool kiemtra( string MaSB)
        {
            string query = " select * from SanBay where MaSB='" + txtmasb.Text + "'";
            DataTable data = Connect.Instace.excutequery(query);
            int dem = 0;
             foreach ( DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        private void dtsanbay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        

        private void txtmasb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtsanbay_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtsanbay.CurrentRow.Index;
            txtmasb.Text = dtsanbay.Rows[i].Cells[0].Value.ToString();
            txttensb.Text = dtsanbay.Rows[i].Cells[1].Value.ToString();
            txtdiachisb.Text = dtsanbay.Rows[i].Cells[2].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if( txtmasb.Text==""|| txttensb.Text == "")
            {
                MessageBox.Show(" vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (kiemtra(txtmasb.Text )== true)
                    {
                        MessageBox.Show(" Mã đã tồn tại");
                        return;
                    }
                    else
                    {
                        string query = "insert into SanBay values ('" + txtmasb.Text + "',N'" + txttensb.Text + "',N'" + txtdiachisb.Text + "')";
                        DataTable data = Connect.Instace.excutequery(query);
                        Load();
                        MessageBox.Show(" Thêm thành công");

                    }
                }
                catch
                {
                    MessageBox.Show(" Thất bại");

                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string query = "delete from SanBay where MaSB = '" + txtmasb.Text + "'";
            DataTable data = Connect.Instace.excutequery(query);
            Load();
            MessageBox.Show(" Xóa thông tin thành công");

        }
         
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string query = "update SanBay set Tensb = '"+txttensb.Text+"' , Diachi = '"+txtdiachisb.Text+ "' where  Masb = '" + txtmasb.Text + "' ";
            DataTable data = Connect.Instace.excutequery(query);
            Load();
            MessageBox.Show(" Sửa thông tin thành công");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
