using AForge.Video.DirectShow;
using MESWinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MESWinForms
{
    public partial class MainForm : Form
    {
        private VideoCaptureDevice _videoCaptureDevice;

        private readonly CameraService _cameraService;
        private readonly FPYService _fpyService;
        private readonly AlarmService _alarmService;


        public MainForm(
            CameraService cameraService,
            FPYService fpyService,
            AlarmService alarmService)
        {
            InitializeComponent();

            lblTitleSysInfo.BackColor = Color.Transparent;
            lblSysMgr.BackColor = Color.Transparent;
            lblTitleCalib.BackColor = Color.Transparent;
            lblTitleFPY.BackColor = Color.Transparent;

            _cameraService = cameraService;
            _fpyService = fpyService;
            _alarmService = alarmService;
        }

        private void MainForm_Load(object sender, EventArgs eventArgs)
        {
            // CenterTop: Camera
            _videoCaptureDevice = _cameraService.StartCamera((s, e) => pbCamera.Image = (Bitmap)e.Frame.Clone());

            var timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += async (s, e) => 
            {
                // RightCenter: FPY
                var fpyVm = await _fpyService.GetAll();



                // RightBottom: Alarm
                var alermVMs = await _alarmService.GetAll();
                lvRightBottom.Items.Clear();
                foreach (var vm in alermVMs)
                {
                    lvRightBottom.Items.Add(
                        new ListViewItem(
                            new string[] { vm.Id.ToString(), vm.System, vm.ResourceType, vm.CurrentTransitionType, vm.LastValue }));
                }
            };
            timer.Start();  
        }



        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _videoCaptureDevice?.Stop();
        }
    }
}
