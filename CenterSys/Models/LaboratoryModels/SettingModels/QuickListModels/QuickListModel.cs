using System;

namespace CenterSys
{
    public class QuickListModel
    {
        public string QuickListId { get; set; }
        public string QuickListCode { get; set; }
        public string QuickListName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public QuickListModel()
        {
            QuickListId = Guid.NewGuid().ToString();
            QuickListCode = "";
            QuickListName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
