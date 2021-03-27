using System;

namespace CenterSys
{
    public class SourceAnalyzesModel
    {
        public string SourceAnalysisId { get; set; }
        public string SourceId { get; set; }
        public string AnalysisPriceId { get; set; }
        public string AnalysisSourceCode { get; set; }
        public SourceAnalyzesModel()
        {
            SourceAnalysisId = Guid.NewGuid().ToString();
            SourceId = "";
            AnalysisPriceId = "";
            AnalysisSourceCode = "";
        }
    }
}
