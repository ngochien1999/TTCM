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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int _img = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
           if(_img == 1 )
            {
                pcchinh.Image = QL.Properties.Resources.maybay2;
                _img = 2;
            } 
         else if(_img == 2)
            {
                pcchinh.Image = QL.Properties.Resources.maybay3;
                _img = 3;
            }  
           else if(_img == 3)
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
        int x = 16 , y = 16 , a=1 ;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void GunaButton7_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            Sanbay f = new Sanbay();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {

            Form5 f = new Form5();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbchao.Location = new Point(x, y);
                if(x>=342)
                {
                    a = -1;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }  
                if(x<=18)
                {
                    a = 1;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }    
               
            }
            catch(Exception)
            { }
        }
    }
}
