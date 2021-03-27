using System;

namespace CenterSys
{
    public class AnalyzesParametersViweModel
    {
        public string AnalysisParameterId { get; set; }
        public string AnalysisId { get; set; }
        public string ParameterId { get; set; }
        public int ParamterOrder { get; set; }
        public AnalyzesParametersViweModel()
        {
            AnalysisParameterId = "";
            AnalysisId = "";
            ParameterId = "";
            ParamterOrder = 0;
        }
    }
}
