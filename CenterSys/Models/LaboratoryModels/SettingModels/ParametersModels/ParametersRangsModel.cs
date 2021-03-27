using System;

namespace CenterSys
{
    public class ParametersRangsModel
    {
        public string RangId { get; set; }
        public string ParameterId { get; set; }
        public string GenderCode { get; set; }
        public string Gender { get; set; }
        public int FromAge { get; set; }
        public int ToAge { get; set; }
        public string StateCode { get; set; }
        public string RangState { get; set; }
        
        public string Rang { get; set; }
        public Decimal MaxLimit { get; set; }
        public Decimal MiniLimit { get; set; }
        public string Equation { get; set; }
        public ParametersRangsModel()
        {
            RangId = Guid.NewGuid().ToString();
            ParameterId = "";
            GenderCode = "";
            Gender = "";
            FromAge = 0;
            ToAge = 0;
            StateCode = "";
            RangState = "";
            Rang = "";
            MaxLimit = 0;
            MiniLimit = 0;
            Equation = "";
        }
    }
}
