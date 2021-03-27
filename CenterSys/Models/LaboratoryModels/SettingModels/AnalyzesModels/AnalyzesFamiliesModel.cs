using System;

namespace CenterSys
{
    public class AnalyzesFamiliesModel
    {
        public string AnalysisFamilyId { get; set; }
        public string AnalysisId { get; set; }
        public string FamilyId { get; set; }
        public AnalyzesFamiliesModel()
        {
            AnalysisFamilyId = Guid.NewGuid().ToString();
            AnalysisId = "";
            FamilyId = "";
        }
    }
}
