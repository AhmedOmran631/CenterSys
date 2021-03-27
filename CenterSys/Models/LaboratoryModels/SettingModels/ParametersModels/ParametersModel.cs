using System;
using System.Collections.Generic;

namespace CenterSys
{
    public class ParametersModel
    {
        public string ParameterId { get; set; }
        public string ParameterCode { get; set; }
        public string ParameterName { get; set; }
        public int ParameterInput { get; set; }
        public string MeasuringUnit { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public bool OnReport { get; set; }
        public bool OnScreen { get; set; }
        public string ParameterReport { get; set; }
        public int StateProcedure { get; set; }
        public List<ParametersRangsModel> ParametersRangs = new List<ParametersRangsModel>();
        public List<ParametersOptionsModel> ParametersOptions = new List<ParametersOptionsModel>();
     

        public ParametersModel()
        {
            ParameterId = Guid.NewGuid().ToString(); 
            ParameterCode = "";
            ParameterName = "";
            ParameterInput = -1;
            MeasuringUnit = "";
            Descrption = "";
            IsActive = true;
            OnReport = true;
            OnScreen = true;
            ParameterReport = "";
            StateProcedure = 1;
        }
    }
}
