using System;
using DevExpress.Xpo;

namespace CenterSys
{

    public class AnalyzesModel 
    {
        public string AnalysisId { get; set; }
        public string AnalysisCode { get; set; }
        public string AnalysisName { get; set; }
        public string AnalysisScientificName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public int Report { get; set; }
        public string RequiredFromTime { get; set; }
        public string RequiredToTime { get; set; }
        public decimal Cost { get; set; }
        public int Currency { get; set; }
        public string Message { get; set; }

        public AnalyzesModel()
        {
            AnalysisId = Guid.NewGuid().ToString(); 
            AnalysisCode = "";
            AnalysisName = "";
            AnalysisScientificName = "";
            Descrption = "";
            IsActive = false;
            Report = 0;
            RequiredFromTime = "";
            RequiredToTime = "";
            Cost = 0;
            Currency = 0;
            Message = "";

        }

   
    }

}