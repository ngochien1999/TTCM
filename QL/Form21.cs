using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace QL
{
    public partial class Form21 : Form
    {
        QLBCMBEntities3 dt = new QLBCMBEntities3();
        public Form21()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void Form21_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form21_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                timer1.Stop();
                if(result != null)
                {
                    txtQRCode.Text = result.ToString();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void txtQRCode_TextChanged(object sender, EventArgs e)
        {
            if (txtQRCode.Text != null || txtQRCode.Text != "")
            {
                var dl = dt.Khachhangs.Where(s=>s.Makh == txtQRCode.Text.Trim()).FirstOrDefault();
                txtten.Text = dl.Tenkh;
                txtsdt.Text = dl.SDTkh.ToString();

            }
        }
    }
}
