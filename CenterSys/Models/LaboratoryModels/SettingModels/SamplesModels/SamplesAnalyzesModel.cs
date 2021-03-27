using System;

namespace CenterSys
{
    public class SamplesAnalyzesModel
    {
        public string SampleAnalysisId { get; set; }
        public string AnalysisId { get; set; }
        public string SampleId { get; set; }
        public SamplesAnalyzesModel()
        {
            SampleAnalysisId = Guid.NewGuid().ToString();
            AnalysisId = "";
            SampleId = "";
        }
    }
}
