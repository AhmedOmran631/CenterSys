using System;

namespace CenterSys
{
    public class SourcesContactsViweModel
    {
        public string ContactId { get; set; }
        public string SourceId { get; set; }
        public string ContactName { get; set; }
        public string ContactJobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Boolean IsActive { get; set; }
        public SourcesContactsViweModel()
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
