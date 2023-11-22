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
        public void AddUserToDatabase(string userName, string password, int roleID)
        {
            try
            {
                DateTime createdAt = DateTime.Now;
                DateTime updatedAt = DateTime.Now;

                var con = Configuration.getInstance().getConnection();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [User] ([UserName], [Password], [RoleID], [CreatedAt], [UpdatedAt]) VALUES (@Username, @Password, @RoleID, @CreatedAt, @UpdatedAt)", con))
                {
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@RoleID", roleID);
                    cmd.Parameters.AddWithValue("@CreatedAt", createdAt);
                    cmd.Parameters.AddWithValue("@UpdatedAt", updatedAt);

                    cmd.ExecuteNonQuery();
                }
                

                Console.WriteLine("User added to the database successfully.");
                MessageBox.Show("New User Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding user to the database: {ex.Message}");
                MessageBox.Show($"Error inserting user into the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
