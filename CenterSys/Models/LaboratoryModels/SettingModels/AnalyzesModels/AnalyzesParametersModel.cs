using System;

namespace CenterSys
{
    public class AnalyzesParametersModel
    {
        public string AnalysisParameterId { get; set; }
        public string AnalysisId { get; set; }
        public string ParameterId { get; set; }
        public int ParamterOrder { get; set; }
        public AnalyzesParametersModel()
        {
            AnalysisParameterId = Guid.NewGuid().ToString();
            AnalysisId = "";
            ParameterId = "";
            ParamterOrder = 0;
        }
    }
}
