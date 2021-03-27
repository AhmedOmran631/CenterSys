using System;

namespace CenterSys
{
    public class ParametersOptionsViweModel
    {
        public string OptionId { get; set; }
        public string ParameterId { get; set; }
        public string OptionName { get; set; }
        public bool IsActive { get; set; }
        public ParametersOptionsViweModel()
        {
            OptionId = "";
            ParameterId = "";
            OptionName = "";
            IsActive = false;
        }
    }
}
