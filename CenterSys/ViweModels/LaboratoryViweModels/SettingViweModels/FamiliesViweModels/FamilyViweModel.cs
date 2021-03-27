using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterSys
{
    public class FamilyViweModel
    {
        public string FamilyId { get; set; }
        public string FamilyCode { get; set; }
        public string FamilyName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public FamilyViweModel()
        {
            FamilyId = "";
            FamilyCode = "";
            FamilyName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
