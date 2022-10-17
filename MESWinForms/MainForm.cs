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

            tlpLeftTop.BackColor = Color.Transparent;
            fpCenterBottom.BackColor = Color.Transparent;


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

        }

        private async Task RefreshCalibrationChartAsync()
        {

        }

        private async Task RefreshFPYChartAsync()
        {
            //var fpyVm = await _fpyService.GetAll();
            //fpFPY.Plot.AddScatter(fpyVm.FPYByMonth.Keys.ToArray(), fpyVm.FPYByMonth.Values.ToArray());
            //fpFPY.Refresh();

            Func<double, string> customFormatter = y => $"Y={y:N2}";

            double[] values = { 77.3, 77.9, 81.2, 76.1, 79.4, 79.2, 78.7, 83.1, 79.9, 83.7, 82.1, 80.9 };
            double[] positions = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var bar = fpFPY.Plot.AddBar(values);
            bar.Label = "Pass Rate";
            bar.ShowValuesAboveBars = true;
            bar.ValueFormatter = customFormatter;
            string[] labels = { "9/21", "10/21", "11/21", "12/21", "1/22", "2/22", "3/22", "4/22", "5/22", "6/22", "7/22", "8/22" };

            fpFPY.Plot.Title("FPY 统计");
            fpFPY.Plot.YAxis.Label("FPY");
            fpFPY.Plot.XAxis.Label("Month");

            fpFPY.Plot.AddBar(values, positions, Color.FromArgb(89, 228, 224));
            Random rand = new Random(40);
            double[] ys = { 93, 95, 98, 87, 96, 90, 96, 93, 94, 92, 95, 93 };
            var line = fpFPY.Plot.AddSignal(ys);
            line.Label = "FPY";
            fpFPY.Plot.XTicks(positions, labels);
            fpFPY.Plot.SetAxisLimits(yMin: 70);
            fpFPY.Plot.Style(Style.Black);
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
