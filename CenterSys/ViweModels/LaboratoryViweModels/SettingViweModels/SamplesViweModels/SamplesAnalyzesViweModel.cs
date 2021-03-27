using System;

namespace CenterSys
{
    public class SamplesAnalyzesViweModel
    {
        public string SampleAnalysisId { get; set; }
        public string AnalysisId { get; set; }
        public string SampleId { get; set; }
        public SamplesAnalyzesViweModel()
        {
            SampleAnalysisId = "";
            AnalysisId = "";
            SampleId = "";
        }
    }
}
