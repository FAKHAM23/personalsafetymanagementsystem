using System;
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WomanSafety.BL;
//using WomanSafety.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WomanSafety.DL
{
    internal class UserDL
    {

        public static bool AddUser(UserBL NewUser)
        {
            // Passwords match, proceed to insert into the database
            try
            {
                var con = Configuration.getInstance().getConnection();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [User] ([UserName], [Password], [RoleID], [CreatedAt], [UpdatedAt]) VALUES (@Username, @Password, @RoleID, @CreatedAt, @UpdatedAt)", con))
                {
                    cmd.Parameters.AddWithValue("@Username", NewUser.UserName);
                    cmd.Parameters.AddWithValue("@Password", NewUser.Password );
                    cmd.Parameters.AddWithValue("@RoleID", NewUser.RoleID);
                    cmd.Parameters.AddWithValue("@CreatedAt", NewUser.CreatedAt);
                    cmd.Parameters.AddWithValue("@UpdatedAt", NewUser.UpdatedAt);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("New User Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting user into the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "AddUser ERROR",
                "YourLoggerName",
                Thread.CurrentThread.ManagedThreadId,
                NewUser.UserID, // Replace with the actual method to get the current user ID
                Environment.MachineName,
                "1.0", // Replace with your actual application version
                "An error occurred.",
                ex.Message,
                ex.StackTrace,
                "Additional information if needed."
                );
                AppLogDL.AddLogException(logEntry);

            }
            return false;
        }
        public static int FindUser(UserBL NewUser)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();

                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM [User] WHERE [UserName] = @Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", NewUser.UserName);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the stored hashed password
                            string storedHashedPassword = reader["Password"].ToString();

                            // Verify the entered password against the stored hash
                            if (PasswordHasher.VerifyPassword(storedHashedPassword, NewUser.Password))
                            {
                                // Retrieve the user's role ID
                                int roleId = Convert.ToInt32(reader["RoleID"]);
                                Console.WriteLine(roleId);

                                // Successful login
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return roleId;
                            }
                        }
                    }

                    // If the code reaches here, the login attempt failed
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "FindUser ERROR",
                "YourLoggerName",
                Thread.CurrentThread.ManagedThreadId,
                NewUser.UserID, // Replace with the actual method to get the current user ID
                Environment.MachineName,
                "1.0", // Replace with your actual application version
                "An error occurred.",
                ex.Message,
                ex.StackTrace,
                "Additional information if needed."
                );
                AppLogDL.AddLogException(logEntry);

            }

            // If the code reaches here, the login attempt failed
            return 0;
        }

        public static int GetUserCount(UserBL user)
        {
            int count = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT COUNT(*) FROM [User] WHERE RoleID = 4";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    count= (int)command.ExecuteScalar();
                }
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "GetUserCount ERROR",
                user.UserName,
                Thread.CurrentThread.ManagedThreadId,
                user.UserID, // Replace with the actual method to get the current user ID
                Environment.MachineName,
                "1.0", // Replace with your actual application version
                "An error occurred.",
                ex.Message,
                ex.StackTrace,
                "Additional information if needed."
                );
                AppLogDL.AddLogException(logEntry);
                return -1;
            }
        }
        public static int GetDeletedUserCount(UserBL user)
        {
            int count = 0;
            try
            {
                var con = Configuration.getInstance().getConnection();
                string query = "SELECT COUNT(*) FROM [User] WHERE RoleID = 4 AND Status = 'Inactive'";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    count = (int)command.ExecuteScalar();
                }
                return count;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "GetUserCount ERROR",
                user.UserName,
                Thread.CurrentThread.ManagedThreadId,
                user.UserID, // Replace with the actual method to get the current user ID
                Environment.MachineName,
                "1.0", // Replace with your actual application version
                "An error occurred.",
                ex.Message,
                ex.StackTrace,
                "Additional information if needed."
                );
                AppLogDL.AddLogException(logEntry);
                return -1;
            }
        }




    }
}
