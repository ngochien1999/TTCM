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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet4.banchay' table. You can move, or remove it, as needed.
            this.banchayTableAdapter.Fill(this.DataSet4.banchay);
            this.reportViewer1.RefreshReport();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
