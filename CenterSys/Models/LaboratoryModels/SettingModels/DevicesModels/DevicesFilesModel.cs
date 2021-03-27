using System;

namespace CenterSys
{

    public class DevicesFilesModel
    {
        public string FileId { get; set; }
        public string DeviceId { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public byte[] DeviceFile { get; set; }
        public DevicesFilesModel()
        {
            FileId = Guid.NewGuid().ToString();
            DeviceId = "";
            FileName = "";
            FileDescription = "";
            DeviceFile = null;
        }
    }
}
