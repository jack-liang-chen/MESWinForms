using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In.TestResult
{
    public class TestResultInMediaType
    {
        public List<Result> results { get; set; }
        public string continuationToken { get; set; }
    }

    public class Properties
    {
        public string nitmSource { get; set; }
        public string nitmProcessModel { get; set; }
        public string nitmTestSocketCount { get; set; }
        public DateTime nitmTestStandStartTime { get; set; }
    }

    public class Result
    {
        public Status status { get; set; }
        public DateTime startedAt { get; set; }
        public DateTime updatedAt { get; set; }
        public string programName { get; set; }
        public string id { get; set; }
        public string systemId { get; set; }
        public string hostName { get; set; }
        public string @operator { get; set; }
        public object partNumber { get; set; }
        public string serialNumber { get; set; }
        public double totalTimeInSeconds { get; set; }
        public List<object> keywords { get; set; }
        public Properties properties { get; set; }
        public List<string> fileIds { get; set; }
        public StatusTypeSummary statusTypeSummary { get; set; }
        public string workspace { get; set; }
    }

    public class Status
    {
        public string statusType { get; set; }
        public object statusName { get; set; }
    }

    public class StatusTypeSummary
    {
        public int LOOPING { get; set; }
        public int SKIPPED { get; set; }
        public int CUSTOM { get; set; }
        public int DONE { get; set; }
        public int PASSED { get; set; }
        public int FAILED { get; set; }
        public int RUNNING { get; set; }
        public int WAITING { get; set; }
        public int TERMINATED { get; set; }
        public int ERRORED { get; set; }
        public int TIMED_OUT { get; set; }
    }
}
