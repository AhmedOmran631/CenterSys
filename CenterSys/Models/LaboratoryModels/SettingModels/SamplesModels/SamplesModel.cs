using System;

namespace CenterSys
{
    public class SamplesModel
    {
        public string SampleId { get; set; }
        public string SampleCode { get; set; }
        public string SampleName { get; set; }
        public int SampleNumber { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public SamplesModel()
        {
            SampleId = Guid.NewGuid().ToString();
            SampleCode = "";
            SampleName = "";
            SampleNumber = 0;
            Descrption = "";
            IsActive = false;
        }
    }
}
