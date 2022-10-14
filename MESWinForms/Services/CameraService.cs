using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESWinForms.Services
{
    public class CameraService
    {
        public VideoCaptureDevice StartCamera(NewFrameEventHandler handler)
        {
            var filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            if (filterInfoCollection.Count == 0) return null;

            var videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += handler;
            videoCaptureDevice.Start();

            return videoCaptureDevice;
        }
    }
}
