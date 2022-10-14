using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.ViewModels
{
    public class AlarmViewModel
    {
        public int Id { get; set; }
        public string System { get; set; }
        public string ResourceType { get; set; }
        public string CurrentTransitionType { get; set; }
        public string LastValue { get; set; }
    }
}
