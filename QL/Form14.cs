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
    public partial class Form14 : Form
    {
        public string matk;
        public int otp;
        public Form14()
        {
            InitializeComponent();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(txtmaxn.Text) == otp)
            {
                Form19 doiMK = new Form19();
                doiMK.matk = matk;
                this.Hide();
                doiMK.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mã OTP không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
