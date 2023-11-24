using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WomanSafety.BL
{
    public class UserBL
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Constructor
        public UserBL(int userID, string userName, string password, int roleID, DateTime createdAt, DateTime updatedAt)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            RoleID = roleID;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        public UserBL( string userName, string password, int roleID, DateTime createdAt, DateTime updatedAt)
        {
            UserName = userName;
            Password = password;
            RoleID = roleID;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        public UserBL(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        



    }

}
