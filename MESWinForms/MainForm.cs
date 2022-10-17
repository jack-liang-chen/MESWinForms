using AForge.Video.DirectShow;
using MESWinForms.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using ScottPlot;

namespace MESWinForms
{
    public partial class MainForm : Form
    {
        private VideoCaptureDevice _videoCaptureDevice;

        private readonly SystemInfoService _systemInfoService;
        private readonly FailedTestService _failedTestService;
        private readonly CameraService _cameraService;
        private readonly DAQService _daqService;
        private readonly CalibService _calibService;
        private readonly FPYService _fpyService;
        private readonly AlarmService _alarmService;

        public MainForm(
            SystemInfoService systemInfoService,
            FailedTestService failedTestService,
            CameraService cameraService,
            DAQService daqService,
            CalibService calibService,
            FPYService fpyService,
            AlarmService alarmService)
        {
            InitializeComponent();

            lblSysInfo.BackColor = Color.Transparent;
            lblSysMgr.BackColor = Color.Transparent;
            lblTitleCalib.BackColor = Color.Transparent;
            lblTitleFPY.BackColor = Color.Transparent;

            //fpSysInfoTop.Plot.Palette = Palette.Nord;
            //double[] values = { 4, 3 };

            //var gauges = fpSysInfoTop.Plot.AddRadialGauge(values);
            //gauges.Labels = new string[] { "系统总数", "运行系统" };

            //Color[] colors = { Color.FromArgb(92, 173, 210), Color.FromArgb(89, 228, 224) };
            //gauges.Colors = colors;

            //fpSysInfoTop.Plot.Legend(true);

            //fpSysInfoTop.Plot.Style(Style.Black);

            ////formsPlot3.Plot.SaveFig("radialgauge_legend.png");
            //fpSysInfoTop.Refresh();




            _systemInfoService = systemInfoService;
            _failedTestService = failedTestService;
            _cameraService = cameraService;
            _daqService = daqService;
            _calibService = calibService;
            _fpyService = fpyService;
            _alarmService = alarmService;
        }

        private async void MainForm_Load(object sender, EventArgs eventArgs)
        {
            _videoCaptureDevice = _cameraService.StartCamera((s, e) => pbCamera.Image = (Bitmap)e.Frame.Clone());
            await RefreshUIAsync();

            var timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += async (s, e) => 
            {
                await RefreshUIAsync();
            };
            timer.Start();  
        }

        private async Task RefreshUIAsync()
        {
            // Left
            await RefreshSysInfoAsync();
            await RefreshFailedCaseChartAsync();

            // Center
            await RefreshDAQChartAsync();

            // Right
            await RefreshCalibrationChartAsync();
            await RefreshFPYChartAsync();
            await RefreshAlarmTableAsync();
        }

        private async Task RefreshSysInfoAsync()
        {

        }

        private async Task RefreshFailedCaseChartAsync()
        {
        
        }

        private async Task RefreshDAQChartAsync()
        {

        }

        private async Task RefreshCalibrationChartAsync()
        {

        }

        private async Task RefreshFPYChartAsync()
        {
            var fpyVm = await _fpyService.GetAll();
            fpFPY.Plot.AddScatter(fpyVm.FPYByMonth.Keys.ToArray(), fpyVm.FPYByMonth.Values.ToArray());
            fpFPY.Refresh();
        }

        private async Task RefreshAlarmTableAsync()
        {
            var alermVMs = await _alarmService.GetAll();
            lvRightBottom.Items.Clear();
            foreach (var vm in alermVMs)
            {
                lvRightBottom.Items.Add(
                    new ListViewItem(
                        new string[] { vm.Id.ToString(), vm.System, vm.ResourceType, vm.CurrentTransitionType, vm.LastValue }));
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _videoCaptureDevice?.Stop();
        }
    }
}
