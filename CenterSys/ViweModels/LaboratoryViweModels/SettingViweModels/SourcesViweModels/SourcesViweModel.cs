using System;
using System.Collections.Generic;

namespace CenterSys
{
    public class SourcesViweModel
    {
        public string SourceId { get; set; }
        public string SourceCode { get; set; }
        public string SourceName { get; set; }
        public string Info { get; set; }
        public string PriceId { get; set; }
        public string Descrption { get; set; }
        public Boolean IsActive { get; set; }

        public List<SourcesAnalyzesModel> SourcesAnalyzes = new List<SourcesAnalyzesModel>();
        public List<SourcesContactsModel> SourcesContacts = new List<SourcesContactsModel>();
        public List<SourcesEmployeesModel> SourcesEmployees = new List<SourcesEmployeesModel>();
        public List<SourcesContractsModel> SourcesContracts = new List<SourcesContractsModel>();
        public SourcesViweModel()
        {
            SourceId = "";
            SourceCode = "";
            SourceName = "";
            Info = "";
            PriceId = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
