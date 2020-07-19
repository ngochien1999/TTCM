using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class frmxacnhan : Form
    {
        public frmxacnhan()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int maxn = 0;
        private void gunaButton1_Click(object sender, EventArgs e)
        {
       
            
                if (txtGmail.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mail.");
                    return;
                }
                string query = " select  Tentk from TK where Ten like '" + txtTK.Text + "' ";
                DataTable data = Connect.Instace.excutequery(query);
                if (data.Rows.Count > 0)
                {
                    string matk = data.Rows[0][0].ToString();
                    string query2 = " select Email from nhanvien where MaNV like '" + matk + "' ";
                    DataTable data2 = Connect.Instace.excutequery(query2);
                    if (data2.Rows.Count > 0)
                    {
                        string gmail = data2.Rows[0][0].ToString();
                        Console.WriteLine(gmail);
                        if (gmail.Equals(txtGmail.Text))
                        {
                            String txttendangnhap = "ntnhien19091999@gmail.com";
                            String txtmk = "ngochien19091999";
                            string email = txtGmail.Text;
                            maxn = random.Next(1000, 9999);
                            MailMessage mail = new MailMessage(txttendangnhap, email, "Mã xác nhận", maxn.ToString());
                            mail.IsBodyHtml = true;
                            SmtpClient client = new SmtpClient("smtp.gmail.com");
                            client.Host = "smtp.gmail.com";
                            client.UseDefaultCredentials = false;
                            client.Port = 587;
                            client.Credentials = new System.Net.NetworkCredential(txttendangnhap, txtmk);
                            client.EnableSsl = true;
                            client.Send(mail);
                            frmotp ma = new frmotp();
                            ma.matk = matk;
                            ma.otp = maxn;
                            this.Hide();
                            ma.ShowDialog();


                            //MaXN2 back = new MaXN2();
                            //ma.Visible = true;
                            //Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("Gmail không đúng", "Thông  Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Tên tài khoản không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        
    
      

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
