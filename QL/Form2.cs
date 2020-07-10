using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace QL
{
    public partial class Form2 : Form
    {
        //Timer t = new Timer();
        //int width = 98, height = 53, secHAND = 30, minHAND = 25, hrHAND = 15;
        //int cx, cy;
        //Bitmap bmp;
        //Graphics g;

        public Form2()
        {
            InitializeComponent();
            
           

        }
        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Opacity = 0;
            fh.Show();
        }
       
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
         
            loadform(new Form10());

        }

        private void GunaButton7_Click(object sender, EventArgs e)
        {
        
            loadform(new Form9());

        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
           
            loadform(new Form12());

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
           
            loadform(new Form5());
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //bmp = new Bitmap(width + 1, height + 1);
            //cx = width / 2;
            //cy = height / 2;
            //this.BackColor = Color.White;
            //t.Interval = 1000;
            //t.Tick += new EventHandler(this.t_Tick);
            //t.Start();
           
            loadform(new Form13());
            timer5.Start();






        }

        //private void t_Tick(object sender, EventArgs e)
        //{
        //    g = Graphics.FromImage(bmp);
        //    int ss = DateTime.Now.Second;
        //    int mm = DateTime.Now.Minute;
        //    int hh = DateTime.Now.Hour;
        //    int[] handCoord = new int[2];
        //    g.Clear(Color.White);
        //    g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, Width, height);
        //    g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
        //    g.DrawString("12", new Font("Arial", 3), Brushes.Black, new PointF(286, 140));
        //    g.DrawString("12", new Font("Arial", 6), Brushes.Black, new PointF(142, 282));
        //    g.DrawString("12", new Font("Arial", 9), Brushes.Black, new PointF(0, 140));
        //    handCoord = msCoord(ss, secHAND );
        //    g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0] , handCoord[1]));
        //    handCoord = msCoord(mm, minHAND);
        //    g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
        //    handCoord = hrCoord(hh%12, mm , hrHAND);
        //    g.DrawLine(new Pen(Color.Black, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));
        //    ptdongho.Image = bmp;
        //    this.Text = " Analog Clock -" +hh + ":" + mm+ ": " + ss;


        //}

        private void ptdongho_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pcchinh_Click(object sender, EventArgs e)
        {

        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100013103702166");
        }

        //private int[] msCoord(int val , int hlen)
        //{
        //    int[] coord = new int[2];
        //    val *= 6;
        //    if(val >= 0 && val <=180)
        //    {
        //        coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
        //        coord[1] = cy + (int)(hlen * Math.Cos(Math.PI * val / 180));

        //    }    
        //    else
        //    {
        //        coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
        //        coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
        //    }
        //    return coord;
        //}
        //private int[] hrCoord(int hval, int mval , int hlen)
        //{
        //    int[] coord = new int[2];
        //   int val = (int)((hval *30) + (mval *0.5));
        //    if (val >= 0 && hval <= 180)
        //    {
        //        coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
        //        coord[1] = cy + (int)(hlen * Math.Cos(Math.PI * val / 180));

        //    }
        //    else
        //    {
        //        coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
        //        coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
        //    }
        //    return coord;
        //}

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }

        private void GunaButton8_Click(object sender, EventArgs e)
        {
          
            frmhoadon f = new frmhoadon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:MM");
        }

        private void lbchao_Click(object sender, EventArgs e)
        {

        }
        int x = 16, y = 16, a = 1;

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbchao.Location = new Point(x, y);
                if (x >= 286)
                {
                    a = -1;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 16)
                {
                    a = 1;
                    lbchao.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }

            }
            catch (Exception)
            { }
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
          
            loadform(new Form8());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           Form15 f = new Form15();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void GunaPictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl1 us = new UserControl1();
            showcontrol(us);
        }
        public void showcontrol(System.Windows.Forms.Control obj)
        {
            pnMain.Controls.Clear();
            obj.Dock = DockStyle.Fill;
            pnMain.Controls.Add(obj);
        }

        Random random = new Random();
        private void timer2_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
