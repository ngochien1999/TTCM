using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            lblDate.Text = tn.ToString("dd/MM/YYYY");
        }
    }
}
