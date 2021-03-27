using System;

namespace CenterSys
{

    public class DevicesFilesViweModel
    {
        public string FileId { get; set; }
        public string DeviceId { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public byte[] DeviceFile { get; set; }
        public DevicesFilesViweModel()
        {
            FileId = "";
            DeviceId = "";
            FileName = "";
            FileDescription = "";
            DeviceFile = null;
        }
    }
}
