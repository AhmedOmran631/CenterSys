using System;

namespace CenterSys
{
    public class AnalyzesQuickListsModel
    {
        public string AnalysisQuickId { get; set; }
        public string AnalysisId { get; set; }
        public string QuickListId { get; set; }
        public AnalyzesQuickListsModel()
        {
            AnalysisQuickId = Guid.NewGuid().ToString();
            AnalysisId = "";
            QuickListId = "";
        }
    }
}
