using System;

namespace CenterSys
{
    public class AnalyzesPricesViweModel
    {
        public string AnalysisPriceId { get; set; }
        public string AnalysisId { get; set; }
        public string PriceId { get; set; }
        public decimal Price { get; set; }
        public AnalyzesPricesViweModel()
        {
            AnalysisPriceId = "";
            AnalysisId = "";
            PriceId = "";
            Price = 0;
        }
    }
}
