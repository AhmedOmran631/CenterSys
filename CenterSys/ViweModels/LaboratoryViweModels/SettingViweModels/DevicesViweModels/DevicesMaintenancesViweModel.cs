using System;

namespace CenterSys
{
    public class DevicesMaintenancesViweModel
    {
        public string MaintenanceId { get; set; }
        public string DeviceId { get; set; }
        public int MaintenanceType { get; set; }
        public int RemindTime { get; set; }
        public string Note { get; set; }
        public DateTime StartDate { get; set; }
        public DevicesMaintenancesViweModel()
        {
            MaintenanceId = "";
            DeviceId = "";
            MaintenanceType = 0;
            RemindTime = 0;
            Note = "";
        }
    }
}
