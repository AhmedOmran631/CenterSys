using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterSys
{
    public class FamilyModel
    {
        public string FamilyId { get; set; }
        public string FamilyCode { get; set; }
        public string FamilyName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public FamilyModel()
        {
            FamilyId = Guid.NewGuid().ToString();
            FamilyCode = "";
            FamilyName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
