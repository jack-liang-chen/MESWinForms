using AForge.Video.DirectShow;
using MESWinForms.Services;
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
        private VideoCaptureDevice _videoCaptureDevice;

        private readonly CameraService _cameraService;
        
        public MainForm(CameraService cameraService)
        {
            InitializeComponent();

            lblTitleSysInfo.BackColor = Color.Transparent;
            lblSysMgr.BackColor = Color.Transparent;
            lblTitleCalib.BackColor = Color.Transparent;
            lblTitleFPY.BackColor = Color.Transparent;

            _cameraService = cameraService;
        }

        private void MainForm_Load(object sender, EventArgs ea)
        {
            _videoCaptureDevice = _cameraService.StartCamera((s, e) => pbCamera.Image = (Bitmap)e.Frame.Clone() );
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _videoCaptureDevice.Stop();
        }
    }
}
