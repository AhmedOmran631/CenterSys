using System;

namespace CenterSys
{
    
    public class DevicesPremissionsViweModel
    {
        public string PremisssionId { get; set; }
        public string DeviceId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DevicesPremissionsViweModel()
        {
            PremisssionId = "";
            DeviceId = "";
            UserName = "";
            Password = "";
            IsActive = false;
        }
    }
}
