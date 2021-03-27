using System;

namespace CenterSys
{
    public class ParametersReportsModel
    {
        public string ReportId { get; set; }
        public string ParameterId { get; set; }
        public string Report { get; set; }
        public ParametersReportsModel()
        {
            ReportId = Guid.NewGuid().ToString();
            ParameterId = "";
            Report = "";
        }
    }
}
