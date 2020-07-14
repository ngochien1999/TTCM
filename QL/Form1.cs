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
        private static string[] demc = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public static string tentkchuan;
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            //(tk.dem == "0" || tk.dem == "1" || tk.dem == "2" || tk.dem == "3" || tk.dem == "4"
            //        || tk.dem == "5" || tk.dem == "6" || tk.dem == "7" || tk.dem == "8" || tk.dem == "9")
            using (QLBCMBEntities3 quanli = new QLBCMBEntities3())
            {
                TK tk = quanli.TKs.FirstOrDefault(p => p.TenTK.Trim() == txttk.Text.Trim() && p.Pass.Trim() == txtmk.Text.Trim());
                if (tk != null && (tk.dem <= 10 || tk.keykh.Length > 3))
                {
                    if(tk.dem <= 10)
                    {
                        quanli.updatekey((tk.dem + 1).ToString(), txttk.Text.Trim());
                        Form2 f = new Form2();
                        this.Hide();
                        this.Show();
                        f.manv = tk.TenTK;
                        f.ShowDialog();
                    }
                    else if(tk.keykh.Length > 3)
                    {
                        Form2 f = new Form2();
                        this.Hide();
                        this.Show();
                        f.manv = tk.TenTK;
                        f.ShowDialog();
                    }
                    
                }
                else if (tk != null && (tk.dem > 10 || tk.keykh == null))
                {
                    tentkchuan = tk.TenTK;
                    DialogResult dr = MessageBox.Show("Bạn Có Muốn Kích Hoạt Key Không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        FormKichHoat f = new FormKichHoat();
                        f.ShowDialog();
                    }
                }
                else if(tk == null)
                {
                    MessageBox.Show("BẠN NHẬP SAI TK HOẶC MK", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_CheckedChanged(object sender, EventArgs e)
        {
            txtmk.Text = txttk.Text = "";
          
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
