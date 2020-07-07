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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            Loaddl();
        }
        public void Loaddl()
        {
            string query = " select * from Ve";
            DataTable data = Connect.Instace.excutequery(query);
            dtve.DataSource = data;


        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dtve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dtve.CurrentRow.Index;
            txtma.Text = dtve.Rows[i].Cells[0].Value.ToString();
            txtkh.Text = dtve.Rows[i].Cells[1].Value.ToString();
            txtsoluong.Text = dtve.Rows[i].Cells[2].Value.ToString();
            txtgia.Text = dtve.Rows[i].Cells[3].Value.ToString();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            string query = "update Ve set  Makh = '" +txtkh.Text + "' , Slg = '" + txtsoluong.Text + "', Giave = '" + txtgia.Text + "' where Mave = '" + txtma.Text + "' ";
            DataTable data = Connect.Instace.excutequery(query);
            MessageBox.Show(" Sửa thông tin thành công");
            Loaddl();
        }
    }
}
