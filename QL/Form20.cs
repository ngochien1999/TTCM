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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            using(QLBCMBEntities3 db = new QLBCMBEntities3())
            {

                
                rptChuyenBayBindingSource.DataSource = db.rptChuyenBay();

                reportViewer1.RefreshReport();
            }
            
        }
    }
}
