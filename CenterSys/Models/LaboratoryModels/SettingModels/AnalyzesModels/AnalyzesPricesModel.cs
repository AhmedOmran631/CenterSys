using System;

namespace CenterSys
{
    public class AnalyzesPricesModel
    {
        public string AnalysisPriceId { get; set; }
        public string AnalysisId { get; set; }
        public string PriceId { get; set; }
        public decimal Price { get; set; }
        public AnalyzesPricesModel()
        {
            AnalysisPriceId = Guid.NewGuid().ToString();
            AnalysisId = "";
            PriceId = "";
            Price = 0;
        }
    }
}
