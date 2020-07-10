using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;




namespace QL
{
    public partial class Form15 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        Attachment attch = null;
        public Form15()
        {
            InitializeComponent();
        }
        QLBCMBEntities1 quanlichuan = new QLBCMBEntities1();
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            attch = null;
            try
            {
                FileInfo file = new FileInfo(textBox1.Text);
                attch = new Attachment(textBox1.Text);
            }
            catch (Exception ex)
            {

            }
            login = new NetworkCredential(txtussename.Text, txtPassword.Text);
            client = new SmtpClient(txtSmtp.Text);
            client.Port = Convert.ToInt32(txtPort.Text);
            client.EnableSsl = chkssl.Checked;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress(txtussename.Text + txtSmtp.Text.Replace("smtp.", "@"), "ngochien", Encoding.UTF8) };
            msg.To.Add(new MailAddress(txtTo.Text));
            if(!string.IsNullOrEmpty(txtTo.Text))
            {
               // msg.To.Add(new MailAddress(txtCC.Text));
                msg.Subject = txtSubject.Text;
                msg.Body = txtMessage.Text;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompleteCallback);
                string usetate = "Sending...";
                client.SendAsync(msg, usetate);
                    

            }    
        }

        private void SendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (attch != null)
            {
                msg.Attachments.Add(attch);
            }
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "message",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Your message has been successfully sent." , "message", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBCMBDataSet14.Khachhang' table. You can move, or remove it, as needed.
            this.khachhangTableAdapter.Fill(this.qLBCMBDataSet14.Khachhang);
            txtTo.DisplayMember = "Email";
            txtTo.ValueMember = "Makh";
            txtTo.DataSource = quanlichuan.Khachhangs.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = dialog.FileName;
            }

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
