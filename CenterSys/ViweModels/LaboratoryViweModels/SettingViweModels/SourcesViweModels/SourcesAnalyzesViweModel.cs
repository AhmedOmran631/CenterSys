using System;

namespace CenterSys
{
    public class SourcesAnalyzesViweModel
    {
        public string SourceAnalysisId { get; set; }
        public string SourceId { get; set; }
        public string AnalysisPriceId { get; set; }
        public string AnalysisSourceCode { get; set; }
        public SourcesAnalyzesViweModel()
        {
            SourceAnalysisId = "";
            SourceId = "";
            AnalysisPriceId = "";
            AnalysisSourceCode = "";
        }
    }
}
