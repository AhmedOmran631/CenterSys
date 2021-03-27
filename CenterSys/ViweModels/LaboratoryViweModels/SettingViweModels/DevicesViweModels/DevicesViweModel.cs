using System;

namespace CenterSys
{
    public class DevicesViweModel
    {
        public string DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public DevicesViweModel()
        {
            DeviceId = "";
            DeviceCode = "";
            DeviceName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
