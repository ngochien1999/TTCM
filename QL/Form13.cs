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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        private int _img = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {



        }

        private void pcchinh_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (_img == 1)
            {
                pcchinh.Image = QL.Properties.Resources.maybay2;
                _img = 2;
            }
            else if (_img == 2)
            {
                pcchinh.Image = QL.Properties.Resources.maybay3;
                _img = 3;
            }
            else if (_img == 3)
            {
                pcchinh.Image = QL.Properties.Resources.maybay5;
                _img = 4;
            }
            else if (_img == 4)
            {
                pcchinh.Image = QL.Properties.Resources.maybay6;
                _img = 5;
            }
            else if (_img == 5)
            {
                pcchinh.Image = QL.Properties.Resources.maybay10;
                _img = 6;
            }
            else if (_img == 6)
            {
                pcchinh.Image = QL.Properties.Resources.maybay11;
                _img = 7;
            }
            else if (_img == 7)
            {
                pcchinh.Image = QL.Properties.Resources.maybay12;
                _img = 12;
            }
            else
            {
                pcchinh.Image = QL.Properties.Resources.maybay2;
                _img = 2;
            }

        }
    }
}
