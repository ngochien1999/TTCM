﻿using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }


        void loadchart1()
        {
            using (QLBCMBEntities3 db = new QLBCMBEntities3())
            {
                chart1.DataSource = db.dthu().ToList();
                chart1.Series["VND"].XValueMember = "thoigian";
                chart1.Series["VND"].YValueMembers = "tongtien";
            }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            loadchart1();
        }

    }

        
}
