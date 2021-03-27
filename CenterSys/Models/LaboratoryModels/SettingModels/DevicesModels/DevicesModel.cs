using System;

namespace CenterSys
{
    public class DevicesModel
    {
        public string DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public DevicesModel()
        {
            DeviceId = Guid.NewGuid().ToString();
            DeviceCode = "";
            DeviceName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
