using System;

namespace CenterSys
{
    public class SourceContactsViweModel
    {
        public string ContactId { get; set; }
        public string SourceId { get; set; }
        public string ContactName { get; set; }
        public string ContactJobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public SourceContactsViweModel()
        {
            ContactId = "";
            SourceId = "";
            ContactName = "";
            ContactJobTitle = "";
            PhoneNumber = "";
            Email = "";
            IsActive = false;
        }
    }
}
