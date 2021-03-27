using System;

namespace CenterSys
{
    public class ParametersOptionsModel
    {
        public string OptionId { get; set; }
        public string ParameterId { get; set; }
        public string OptionName { get; set; }
        public bool IsActive { get; set; }
        public ParametersOptionsModel()
        {
            OptionId = Guid.NewGuid().ToString();
            ParameterId = "";
            OptionName = "";
            IsActive = false;
        }
    }
}
