using System;

namespace CenterSys
{
    public class PricesViweModel
    {
        public string PriceId { get; set; }
        public string PriceCode { get; set; }
        public string PriceName { get; set; }
        public int Currency { get; set; }
        public int CoinSymbol { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public PricesViweModel()
        {
            PriceId = "";
            PriceCode = "";
            PriceName = "";
            Currency = 0;
            CoinSymbol = 0;
            Descrption = "";
            IsActive = false;
        }
    }
}
