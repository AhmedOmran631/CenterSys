using System;

namespace CenterSys
{
    public class AnalyzesDevicesViweModel
    {
        public string AnalysisDeviceId { get; set; }
        public string AnalysisId { get; set; }
        public string DeviceId { get; set; }
        public AnalyzesDevicesViweModel()
        {
            AnalysisDeviceId = Guid.NewGuid().ToString(); 
            AnalysisId = "";
            DeviceId = "";
        }
    }
}
