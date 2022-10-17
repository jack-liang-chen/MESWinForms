using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESWinForms.MediaTypes.In
{
    public class AssetsInMediaType
    {
        public List<Asset> assets { get; set; }
        public int totalCount { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Asset
    {
        public string modelName { get; set; }
        public int modelNumber { get; set; }
        public string serialNumber { get; set; }
        public string vendorName { get; set; }
        public int vendorNumber { get; set; }
        public string busType { get; set; }
        public string name { get; set; }
        public string assetType { get; set; }
        public string discoveryType { get; set; }
        public string firmwareVersion { get; set; }
        public string hardwareVersion { get; set; }
        public string visaResourceName { get; set; }
        public List<object> temperatureSensors { get; set; }
        public bool supportsSelfCalibration { get; set; }
        public bool supportsExternalCalibration { get; set; }
        public bool isNIAsset { get; set; }
        public string id { get; set; }
        public Location location { get; set; }
        public string calibrationStatus { get; set; }
        public bool isSystemController { get; set; }
        public string workspace { get; set; }
        public Properties properties { get; set; }
        public List<object> keywords { get; set; }
        public DateTime lastUpdatedTimestamp { get; set; }
        public List<object> fileIds { get; set; }
        public bool supportsSelfTest { get; set; }
        public bool supportsReset { get; set; }
        public ExternalCalibration externalCalibration { get; set; }
    }

    public class ExternalCalibration
    {
        public List<TemperatureSensor> temperatureSensors { get; set; }
        public bool isLimited { get; set; }
        public DateTime date { get; set; }
        public int recommendedInterval { get; set; }
        public DateTime nextRecommendedDate { get; set; }
        public string comments { get; set; }
        public string entryType { get; set; }
        public Operator @operator { get; set; }
        public DateTime? nextCustomDueDate { get; set; }
    }

    public class Location
    {
        public string minionId { get; set; }
        public string parent { get; set; }
        public string resourceUri { get; set; }
        public int slotNumber { get; set; }
        public string systemName { get; set; }
        public State state { get; set; }
    }

    public class Operator
    {
        public string displayName { get; set; }
        public string userId { get; set; }
    }

    public class Properties
    {
    }

    public class State
    {
        public string assetPresence { get; set; }
        public string systemConnection { get; set; }
    }

    public class TemperatureSensor
    {
        public int reading { get; set; }
    }


}
