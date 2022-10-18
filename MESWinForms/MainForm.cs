using AForge.Video.DirectShow;
using MESWinForms.Services;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using ScottPlot;
using System.Configuration;
using System.Collections.Generic;
using AForge.Video;

namespace MESWinForms
{
    public partial class MainForm : Form
    {
        private const int QueueCapacity = 40;
        private Queue<double> _temperatureQueue = new Queue<double>();
        private Queue<double> _pressureQueue = new Queue<double>();
        private Queue<double> _lightQueue = new Queue<double>();

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
            tlpLeftTop.BackColor = Color.Transparent;
            fpCenterBottom.BackColor = Color.Transparent;

            fpSysInfoTop.Plot.Style(Style.Black);


            fpSysInfoBottom.Plot.Style(Style.Black);



            fpFailedCaseTop.Plot.Title("Failed测试分析");
            fpFailedCaseTop.Plot.Style(Style.Black);


            fpFailedCaseBottom.Plot.Title("Failed测试统计");
            fpFailedCaseBottom.Plot.Style(Style.Black);



            fpCenterBottom.Plot.Title("监控显示");
            fpCenterBottom.Plot.YAxis.Label("值");

            fpCalib.Plot.Style(Style.Black);
            fpCalib.Plot.Legend(true);


            fpCenterBottom.Plot.Style(Style.Black);
            fpFPY.Plot.Title("FPY 统计");
            fpFPY.Plot.YAxis.Label("FPY");
            fpFPY.Plot.XAxis.Label("月");
            fpFPY.Plot.Style(Style.Black);

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
            _videoCaptureDevice = _cameraService.StartCamera(DisplayCamera);
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

        private void DisplayCamera(object sender, NewFrameEventArgs e)
        {
            pbCamera.Image = (Bitmap)e.Frame.Clone();
        }

        private async Task RefreshUIAsync()
        {
            // DateTime
            var now = DateTime.Now;
            lblDateTime.Text = now.Year + "年" + now.Month + "月" + now.Day + "日" +
                DateTime.Now.ToString("hh:mm:ss");

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
            lblMgrSysValue.Text = (await _systemInfoService.GetSystemsCountAsync()).ToString();
            lblConnectionDev.Text = (await _systemInfoService.GetConnectionDeviceCountAsync()).ToString();
        }

        private async Task RefreshFailedCaseChartAsync()
        {
        
        }

        private async Task RefreshDAQChartAsync()
        {
            fpCenterBottom.Plot.Clear();

            // Temperature
            var currentTempData = await _daqService.GetCurrentTagValue("tempetaure.tag");
            var currentTempValue = double.Parse(currentTempData);
            _temperatureQueue.Enqueue(currentTempValue);

            if (_temperatureQueue.Count == QueueCapacity)
                _temperatureQueue.Dequeue();

            fpCenterBottom.Plot.AddSignal(_temperatureQueue.ToArray());

            // Pressure
            var currentPressureData = await _daqService.GetCurrentTagValue("Presure.tag");
            var currentPressureValue = double.Parse(currentPressureData);
            _pressureQueue.Enqueue(currentPressureValue);

            if (_pressureQueue.Count == QueueCapacity)
                _pressureQueue.Dequeue();

            fpCenterBottom.Plot.AddSignal(_pressureQueue.ToArray());

            // Light
            var currentLightData = await _daqService.GetCurrentTagValue("Light.tag");
            var currentLightValue = double.Parse(currentLightData);
            _lightQueue.Enqueue(currentLightValue);

            if (_lightQueue.Count == QueueCapacity)
                _lightQueue.Dequeue();

            fpCenterBottom.Plot.AddSignal(_lightQueue.ToArray());


            fpCenterBottom.Refresh();
        }

        private async Task RefreshCalibrationChartAsync()
        {
            fpCalib.Plot.Clear();

            var data = await _systemInfoService.GetAssetsAsync();
            var deviceTotalCount = data.totalCount;
            var disConnectedDeviceCount = data.assets.Where(x => x.location.state.systemConnection == "DISCONNECTED").Count();
            var connectedDeviceCount = deviceTotalCount - disConnectedDeviceCount;
            var supportedSeftCalibDevs = data.assets.Where(x => x.supportsSelfCalibration).Count();
            var supportedExtCalibDevs = data.assets.Where(x => x.supportsExternalCalibration).Count();

            var gauges = fpCalib.Plot.AddRadialGauge(
                new double[] { 
                    deviceTotalCount, 
                    connectedDeviceCount, 
                    disConnectedDeviceCount, 
                    supportedSeftCalibDevs, 
                    supportedExtCalibDevs });
            gauges.Labels = new string[] { "设备总数", "已连接设备", "非连接设备", "支持自校准设备", "支持外部校准设备"};
            gauges.Colors = new Color[] { 
                Color.FromArgb(105, 48, 169), 
                Color.FromArgb(79, 84, 178), 
                Color.FromArgb(63, 116, 217), 
                Color.FromArgb(92, 173, 210), 
                Color.FromArgb(89, 228, 224) };

            fpCalib.Refresh();
        }

        private async Task RefreshFPYChartAsync()
        {
            var fpyVm = await _fpyService.GetAll();
            var resolved = fpyVm.FPYByMonth.Reverse();
            var months = resolved.Select(x => x.Key).ToArray();
            var values = resolved.Select(x => x.Value).ToArray();

            string[] labels = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
            fpFPY.Plot.XTicks(months, labels);

            fpFPY.Plot.AddBar(values, months, Color.FromArgb(89, 228, 224));
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
