using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomanSafety.BL
{
    class ReportBL
    {
        public int ReportID { get; set; }
        public int UserID { get; set; }
        public int? LocationID { get; set; }
        public string FeedbackText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public ReportBL()
        {

        }
        public ReportBL(int reportID, int userID, string feedbackText, DateTime createdAt, DateTime updatedAt)
        {
            ReportID = reportID;
            UserID = userID;
            FeedbackText = feedbackText;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        public ReportBL(int userID, int? locationID, string feedbackText, DateTime createdAt, DateTime updatedAt)
        {
            UserID = userID;
            LocationID = locationID;
            FeedbackText = feedbackText;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        // Parameterized constructor
        public ReportBL(int reportID, int userID, int? locationID, string feedbackText, DateTime createdAt, DateTime updatedAt)
        {
            ReportID = reportID;
            UserID = userID;
            LocationID = locationID;
            FeedbackText = feedbackText;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }




    }
}
