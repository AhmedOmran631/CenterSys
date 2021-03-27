using System;

namespace CenterSys
{
    public class SourcesContractsViweModel
    {
        public string ContractId { get; set; }
        public string SourceId { get; set; }
        public string ContractCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RenewDate { get; set; }
        public int RemindTime { get; set; }
        public Boolean IsActive { get; set; }
        public SourcesContractsViweModel()
        {
            ContractId = "";
            SourceId = "";
            ContractCode = "";
            StartDate = DateTime.Now;
            EndDate = DateTime.Now;
            RenewDate = DateTime.Now;
            RemindTime = 0;
            IsActive = false;
        }
    }
}
