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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có thực sự muốn thoát chương trình ?", "Chú ý !",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (tl == DialogResult.Yes) { Application.Exit(); }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ? ", "Thông báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
           if(txttk.Text=="admin" && txtmk.Text=="12345")
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
           else if(txttk.Text == "" && txtmk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !!!");
            }   
           else if(txttk.Text=="nhanvien " && txtmk.Text == "12345")
            {

                Form16 f = new Form16();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }    
           
            else
            {
                MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu vui lòng kiểm tra lại !!!");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.Text = txttk.Text = "";
        }
    }
}
