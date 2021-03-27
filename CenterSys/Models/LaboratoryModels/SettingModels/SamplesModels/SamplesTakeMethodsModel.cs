using System;

namespace CenterSys
{
    public class SamplesTakeMethodsModel
    {
        public string TakeMethodId { get; set; }
        public string SampleId { get; set; }
        public byte[] TakeMethod { get; set; }
        public SamplesTakeMethodsModel()
        {
            TakeMethodId = Guid.NewGuid().ToString();
            SampleId = "";
            TakeMethod = null;
        }
    }
}
