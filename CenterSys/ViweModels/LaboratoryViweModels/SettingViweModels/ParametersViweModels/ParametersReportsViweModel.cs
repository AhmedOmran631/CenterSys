using System;

namespace CenterSys
{
    public class ParametersReportsViweModel
    {
        public string ReportId { get; set; }
        public string ParameterId { get; set; }
        public string Report { get; set; }
        public ParametersReportsViweModel()
        {
            ReportId = Guid.NewGuid().ToString();
            ParameterId = "";
            Report = "";
        }
    }
}
