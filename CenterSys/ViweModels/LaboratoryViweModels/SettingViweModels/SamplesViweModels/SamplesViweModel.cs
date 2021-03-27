using System;

namespace CenterSys
{
    public class SamplesViweModel
    {
        public string SampleId { get; set; }
        public string SampleCode { get; set; }
        public string SampleName { get; set; }
        public int SampleNumber { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public SamplesViweModel()
        {
            SampleId = "";
            SampleCode = "";
            SampleName = "";
            SampleNumber = 0;
            Descrption = "";
            IsActive = false;
        }
    }
}
