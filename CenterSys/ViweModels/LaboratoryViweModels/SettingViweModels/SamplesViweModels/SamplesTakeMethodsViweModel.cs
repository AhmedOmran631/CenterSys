using System;

namespace CenterSys
{
    public class SamplesTakeMethodsViweModel
    {
        public string TakeMethodId { get; set; }
        public string SampleId { get; set; }
        public byte[] TakeMethod { get; set; }
        public SamplesTakeMethodsViweModel()
        {
            TakeMethodId = "";
            SampleId = "";
            TakeMethod = null;
        }
    }
}
