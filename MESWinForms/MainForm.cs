using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        VideoCaptureDevice _videoCaptureDevice;

        private void MainForm_Load(object sender, EventArgs e)
        {
            var filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            _videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            _videoCaptureDevice.NewFrame += _videoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void _videoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _videoCaptureDevice.Stop();
        }
    }
}
