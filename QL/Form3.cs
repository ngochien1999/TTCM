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
        public void Load()
        {
            string query = " select * from Nhanvien";
            DataTable data = Connect.Instace.excutequery(query);
            dtnhanvien.DataSource = data;

        }
        public bool kiemtra(string manv)
        {
            string query = " select * from Nhanvien where MaNV='" +txtMaNV.Text + "'";
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
      
        public Form3()
        {
            InitializeComponent();
            Load();
        }

        private void dtnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtnhanvien.CurrentRow.Index;
           txtMaNV.Text = dtnhanvien.Rows[i].Cells[0].Value.ToString();
            txtNhanvien.Text = dtnhanvien.Rows[i].Cells[1].Value.ToString();
            txtCMND.Text = dtnhanvien.Rows[i].Cells[2].Value.ToString();
           txtDiachi.Text = dtnhanvien.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dtnhanvien.Rows[i].Cells[4].Value.ToString();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtNhanvien.Text == "" || txtCMND.Text == "" || txtSDT.Text=="" || txtDiachi.Text=="")
            {
                MessageBox.Show(" vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    if (kiemtra(txtMaNV.Text) == true)
                    {
                        MessageBox.Show(" Mã đã tồn tại");
                        return;
                    }
                    else
                    {
                        string query = "insert into Nhavien values (N'" + txtMaNV.Text + "',N'" + txtNhanvien.Text + "',N'" + txtCMND.Text + "' ,N'"+txtDiachi.Text+"', N'"+txtSDT.Text+"' )";
                        DataTable data = Connect.Instace.excutequery(query);
                        Load();
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
                if (txtMaNV.Text == "")
                {
                    MessageBox.Show(" Vui Long chon dong can xoa");
                    return;
                }
                else
                {
                    string query = "delete from Nhanvien where MaNV = '" + txtMaNV.Text + "'";
                    DataTable data = Connect.Instace.excutequery(query);
                    Load();
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
            string query = "update Nhanvien set TenNV = '" + txtNhanvien.Text + "' , CMND = '" + txtCMND.Text + "', Diachi = '" + txtDiachi.Text + "' , SĐT = '" + txtSDT.Text + "' where MaNV = '"+txtMaNV.Text+"' ";
            DataTable data = Connect.Instace.excutequery(query);
            MessageBox.Show(" Sửa thông tin thành công");
            Load();
        }
        Connect connect = new Connect();

        public DataTable DataTable { get; private set; }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()== "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cần tìm kiếm !!!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
            else
            {
                DataTable = new DataTable();
                if(DataTable.Rows.Count > 0)
                {
                    dtnhanvien.DataSource = DataTable;
                } 
                else
                {
                    MessageBox.Show("Bạn tìm :" + txtNhanvien.Text + "không có trong dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                    txtNhanvien.Text = "";
                }    

                
                
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }
    }
}
