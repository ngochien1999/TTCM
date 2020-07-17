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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

            using(QLBCMBEntities3 db = new QLBCMBEntities3())
            {


                //layhoadonBindingSource.DataSource = db.layhoadon();

                reportViewer1.RefreshReport();
            }
        }
    }
}
