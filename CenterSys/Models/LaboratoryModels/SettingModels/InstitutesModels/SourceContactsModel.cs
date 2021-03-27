using System;

namespace CenterSys
{
    public class SourceContactsModel
    {
        public string ContactId { get; set; }
        public string SourceId { get; set; }
        public string ContactName { get; set; }
        public string ContactJobTitle { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public SourceContactsModel()
        {
            ContactId = Guid.NewGuid().ToString();
            SourceId = "";
            ContactName = "";
            ContactJobTitle = "";
            PhoneNumber = "";
            Email = "";
            IsActive = false;
        }
    }
}
