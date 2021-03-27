using System;

namespace CenterSys
{
    public class QuickListViweModel
    {
        public string QuickListId { get; set; }
        public string QuickListCode { get; set; }
        public string QuickListName { get; set; }
        public string Descrption { get; set; }
        public bool IsActive { get; set; }
        public QuickListViweModel()
        {
            QuickListId = "";
            QuickListCode = "";
            QuickListName = "";
            Descrption = "";
            IsActive = false;
        }
    }
}
