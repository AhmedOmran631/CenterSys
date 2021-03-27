using System;

namespace CenterSys
{
    public class AnalyzesFamiliesViweModel
    {
        public string AnalysisFamilyId { get; set; }
        public string AnalysisId { get; set; }
        public string FamilyId { get; set; }
        public AnalyzesFamiliesViweModel()
        {
            AnalysisFamilyId = Guid.NewGuid().ToString();
            AnalysisId = "";
            FamilyId = "";
        }
    }
}
