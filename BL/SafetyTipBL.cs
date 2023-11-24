using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomanSafety.BL
{
    class SafetyTipBL
    {
        public int TipID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int UserID { get; set; }

        public SafetyTipBL(string title, string description, int userID)
        {
            Title = title;
            Description = description;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            UserID = userID;
        }



    }
}
