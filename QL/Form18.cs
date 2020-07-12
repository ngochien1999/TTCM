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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBCMBDataSet10.Maybay' table. You can move, or remove it, as needed.
            this.MaybayTableAdapter.Fill(this.QLBCMBDataSet10.Maybay);

            this.reportViewer1.RefreshReport();
            loadchart();
        }
        void loadchart()
        {
            using(QLBCMBEntities3 db = new QLBCMBEntities3())
            {
                chart1.DataSource = db.doanhthu().ToList();
                chart1.Series["VND"].XValueMember = "thoigian";
                chart1.Series["VND"].YValueMembers = "tongtien";
            }
        }
    }
}
