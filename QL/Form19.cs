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
    public partial class Form19 : Form
    {
        public string matk;
        public Form19()
        {
            InitializeComponent();
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpassmoi.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtpass.Text != txtpassmoi.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtpass.Text.Equals(txtpassmoi.Text))
            {
                string query = " update TK set pass='" + txtpassmoi.Text + "' where TenTK like '" + matk + "' ";
                int data = Connect.Instace.updateTaikhoan(query);
                if (data > 0)
                    MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmLogin back = new frmLogin();
                back.Visible = true;
            }
            else
            {
                MessageBox.Show("Mật khẩu chưa trùng.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
    

