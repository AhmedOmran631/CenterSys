using System;

namespace CenterSys
{
    public class ParametersDevicesModel
    {
        public string ParameterDeviceId { get; set; }
        public string ParameterId { get; set; }
        public string AnalysisDeviceId { get; set; }
        public string ParamterDeviceCode { get; set; }
        public ParametersDevicesModel()
        {
            ParameterDeviceId = Guid.NewGuid().ToString();
            ParameterId = "";
            AnalysisDeviceId = "";
            ParamterDeviceCode = "";
        }
    }
}
