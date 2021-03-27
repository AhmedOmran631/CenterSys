using System;

namespace CenterSys
{
    public class SourceAnalyzesViweModel
    {
        public string SourceAnalysisId { get; set; }
        public string SourceId { get; set; }
        public string AnalysisPriceId { get; set; }
        public string AnalysisSourceCode { get; set; }
        public SourceAnalyzesViweModel()
        {
            SourceAnalysisId = "";
            SourceId = "";
            AnalysisPriceId = "";
            AnalysisSourceCode = "";
        }
    }
}
