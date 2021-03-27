using System;

namespace CenterSys
{
    public class SourceModel
    {
        public string SourceId { get; set; }
        public string SourceCode { get; set; }
        public string SourceName { get; set; }
        public string Info { get; set; }
        public string PriceId { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public SourceModel()
        {
            SourceId = Guid.NewGuid().ToString();
            SourceCode = "";
            SourceName = "";
            Info = "";
            PriceId = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
