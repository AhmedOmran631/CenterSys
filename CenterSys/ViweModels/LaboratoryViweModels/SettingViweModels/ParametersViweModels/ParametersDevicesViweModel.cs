using System;

namespace CenterSys
{
    public class ParametersDevicesViweModel
    {
        public string ParameterDeviceId { get; set; }
        public string ParameterId { get; set; }
        public string AnalysisDeviceId { get; set; }
        public string ParamterDeviceCode { get; set; }
        public ParametersDevicesViweModel()
        {
            ParameterDeviceId = "";
            ParameterId = "";
            AnalysisDeviceId = "";
            ParamterDeviceCode = "";
        }
    }
}
