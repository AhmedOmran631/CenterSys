using System;

namespace CenterSys
{
    public class SourceEmployeeViweModel
    {
        public string EmployeeId { get; set; }
        public string SourceId { get; set; }
        public string WorkId { get; set; }
        public string BeneficiaryId { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string FamilyName { get; set; }
        public string FileId { get; set; }
        public string Relation { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsActive { get; set; }
        public string Nationality { get; set; }
        public SourceEmployeeViweModel()
        {
            EmployeeId = "";
            SourceId = "";
            WorkId = "";
            BeneficiaryId = "";
            FirstName = "";
            FatherName = "";
            GrandFatherName = "";
            FamilyName = "";
            FileId = "";
            Relation = "";
            Gender = "";
            BirthDay = DateTime.Now;
            IsActive = false;
            Nationality = "";
        }
    }
}
