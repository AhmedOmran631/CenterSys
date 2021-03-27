using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterSys
{
    public class DevicesErrorMessagesModel
    {
        public string ErrorMessageId { get; set; }
        public string DeviceId { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public DateTime ErrorTime { get; set; }
        public DevicesErrorMessagesModel()
        {
            ErrorMessageId = Guid.NewGuid().ToString();
            DeviceId = "";
            ErrorCode = "";
            ErrorDescription = "";
            ErrorTime = DateTime.Now;
        }
    }
}
