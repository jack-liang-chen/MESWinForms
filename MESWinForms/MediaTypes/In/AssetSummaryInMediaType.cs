using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In
{
    public class AssetSummaryInMediaType
    {
        public int active { get; set; }
        public int notActive { get; set; }
        public int total { get; set; }
        public int inUse { get; set; }
        public int notInUse { get; set; }
        public int withAlarms { get; set; }
        public int approachingRecommendedDueDate { get; set; }
        public int pastRecommendedDueDate { get; set; }
        public int totalCalibrated { get; set; }
    }
}
