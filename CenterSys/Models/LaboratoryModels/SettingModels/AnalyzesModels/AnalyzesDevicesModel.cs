using System;

namespace CenterSys
{
    public class AnalyzesDevicesModel
    {
        public string AnalysisDeviceId { get; set; }
        public string AnalysisId { get; set; }
        public string DeviceId { get; set; }
        public AnalyzesDevicesModel()
        {
            AnalysisDeviceId = Guid.NewGuid().ToString();
            AnalysisId = "";
            DeviceId = "";
        }
    }
}
