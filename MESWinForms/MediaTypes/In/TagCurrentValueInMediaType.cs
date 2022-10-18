using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In
{
    public class TagCurrentValueInMediaType
    {
        public List<TagsWithValue> tagsWithValues { get; set; }
        public int totalCount { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Aggregates
    {
        public int count { get; set; }
        public double avg { get; set; }
        public string min { get; set; }
        public string max { get; set; }
    }

    public class Current
    {
        public DateTime timestamp { get; set; }
        public Value value { get; set; }
    }

    public class TagCurrentValueProperties
    {
        public string nitagRetention { get; set; }
        public string nitagHistoryTTLDays { get; set; }
        public string nitagMaxHistoryCount { get; set; }
    }

    public class Tag
    {
        public string path { get; set; }
        public string type { get; set; }
        public TagCurrentValueProperties properties { get; set; }
        public List<object> keywords { get; set; }
        public bool collectAggregates { get; set; }
        public string workspace { get; set; }
    }

    public class TagsWithValue
    {
        public Tag tag { get; set; }
        public Current current { get; set; }
        public Aggregates aggregates { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string value { get; set; }
    }
}
