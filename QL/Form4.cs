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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Load1();
        }
        public void Load1()
        {
            string query = " select * from Maybay";
            DataTable data = Connect.Instace.excutequery(query);
            dtmaybay.DataSource = data;

        }
        public bool kiemtra(string manv)
        {
            string query = " select * from Maybay where MaMB='" + txtmamb.Text + "'";
            DataTable data = Connect.Instace.excutequery(query);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtmaybay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            int row = e.RowIndex;
            if (row < 0)
            {
                return;
            }
            else
            {
                i = dtmaybay.CurrentRow.Index;
                txtmamb.Text = dtmaybay.Rows[i].Cells[0].Value.ToString();
                txttenmb.Text = dtmaybay.Rows[i].Cells[1].Value.ToString();
                txthangmb.Text = dtmaybay.Rows[i].Cells[2].Value.ToString();
            }
           
          
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtmamb.Text == "" || txttenmb.Text == "")
            {
                MessageBox.Show(" vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (kiemtra(txtmamb.Text) == true)
                    {
                        MessageBox.Show(" Mã đã tồn tại");
                        return;
                    }
                    else
                    {
                        string query = "insert into Maybay values (N'" + txtmamb.Text + "',N'" + txttenmb.Text + "',N'" + txthangmb.Text + "' )";
                        DataTable data = Connect.Instace.excutequery(query);
                        Load1();
                        MessageBox.Show(" Thêm thành công");

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm Thất bại");

                }
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmamb.Text == "")
                {
                    MessageBox.Show(" Vui Long chon dong can xoa");
                    return;
                }
                else
                {
                    string query = "delete from Maybay where MaMB = '" + txtmamb.Text + "'";
                    DataTable data = Connect.Instace.excutequery(query);
                    Load1();
                    MessageBox.Show(" Xóa thông tin thành công");
                }

            }
            catch
            {
                MessageBox.Show(" Xoa that bai");
            }
          
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string query = "update Maybay set TenMb = '" + txttenmb.Text + "' ," + " Hang =N'" + txthangmb.Text + "'" + " where MaMB = '" + txtmamb.Text + "'"; 
            DataTable data = Connect.Instace.excutequery(query);
            MessageBox.Show(" Sửa thông tin thành công");
            Load1();
           
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}

