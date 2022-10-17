using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In
{
    public class TagHistoryInMediaType
    {
        public string continuationToken { get; set; }
        public object error { get; set; }
        public object failed { get; set; }
        public string type { get; set; }
        public List<TagValue> values { get; set; }
        public string workspace { get; set; }
    }

    public class TagValue
    {
        public DateTime timestamp { get; set; }
        public string value { get; set; }
    }
}
