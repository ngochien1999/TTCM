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
        //void control()
        //{
        //    using (QLBCMBEntities3 db = new QLBCMBEntities3())
        //    {
        //        chartControl1.DataSource = db.dthu().ToList();
        //        chartControl1.X= "thoigian";
        //        chartControl1.Series["VND"] = "tongtien";
        //    }
        //}
        void loadchart()
        {
            using (QLBCMBEntities3 db = new QLBCMBEntities3())
            {
                chart1.DataSource = db.tongdthu().ToList();
                chart1.Series["VND"].YValueMembers = "tongtien";
            }
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            loadchart();
            //control();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
