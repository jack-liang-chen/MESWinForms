using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In
{
    public class AlarmInMediaType
    {
        public int totalCount { get; set; }
        public List<FilterMatch> filterMatches { get; set; }
    }

    public class FilterMatch
    {
        public string instanceId { get; set; }
        public string alarmId { get; set; }
        public string workspace { get; set; }
        public bool active { get; set; }
        public bool clear { get; set; }
        public bool acknowledged { get; set; }
        public object acknowledgedAt { get; set; }
        public object acknowledgedBy { get; set; }
        public int currentSeverityLevel { get; set; }
        public int highestSeverityLevel { get; set; }
        public DateTime occurredAt { get; set; }
        public string createdBy { get; set; }
        public List<Transition> transitions { get; set; }
        public int transitionOverflowCount { get; set; }
        public List<string> notificationStrategyIds { get; set; }
        public DateTime updatedAt { get; set; }
        public string channel { get; set; }
        public string resourceType { get; set; }
        public string condition { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public Properties properties { get; set; }
        public List<object> keywords { get; set; }
        public List<object> notes { get; set; }
    }

    public class Properties
    {
        public string nitagRetention { get; set; }
        public string nitagHistoryTTLDays { get; set; }
        public string nitagMaxHistoryCount { get; set; }
        public string minionId { get; set; }
        public string displayName { get; set; }
        public string units { get; set; }
        public string hyperlink { get; set; }
        public string value { get; set; }
        public string valueType { get; set; }
        public string nitagrulePredefinedRuleId { get; set; }
        public string nitagruleRuleId { get; set; }
        public string nitagruleRuleVersion { get; set; }
        public string system { get; set; }
    }

    public class Transition
    {
        public string transitionType { get; set; }
        public DateTime occurredAt { get; set; }
        public int severityLevel { get; set; }
        public string condition { get; set; }
        public string shortText { get; set; }
        public string detailText { get; set; }
        public Properties properties { get; set; }
        public List<object> keywords { get; set; }
    }
}
