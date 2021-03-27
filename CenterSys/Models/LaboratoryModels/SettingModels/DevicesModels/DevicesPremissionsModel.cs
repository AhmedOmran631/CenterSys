using System;

namespace CenterSys
{
    
    public class DevicesPremissionsModel
    {
        public string PremisssionId { get; set; }
        public string DeviceId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DevicesPremissionsModel()
        {
            PremisssionId = Guid.NewGuid().ToString();
            DeviceId = "";
            UserName = "";
            Password = "";
            IsActive = false;
        }
    }
}
