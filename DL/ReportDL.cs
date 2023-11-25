using System;
using System.Threading;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WomanSafety.BL;
using WomanSafety.UI;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WomanSafety.DL
{
    class ReportDL
    {
        public static DataTable GetReportsByUser(UserBL user)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = Configuration.getInstance().getConnection())
                {
                    string query = "SELECT ReportID, UserID,  FeedbackText, CreatedAt, UpdatedAt FROM Report WHERE UserID = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", user.UserID);

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            // Fill the DataTable with the results from the SQL query
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error retrieving reports: {ex.Message}");
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                    DateTime.Now,
                    "GetReportsByUser ERROR",
                    user.UserName,
                    Thread.CurrentThread.ManagedThreadId,
                    user.UserID,
                    Environment.MachineName,
                    "1.0",
                    "An error occurred.",
                    ex.Message,
                    ex.StackTrace,
                    "Additional information if needed."
                );

                AppLogDL.AddLogException(logEntry);
            }

            return dataTable;
        }




        public static bool AddReport(ReportBL newReport, UserBL LoggedInUser)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Report (UserID, LocationID, FeedbackText, CreatedAt, UpdatedAt) VALUES (@UserID, @LocationID, @FeedbackText, @CreatedAt, @UpdatedAt)", con))
                {
                    cmd.Parameters.AddWithValue("@UserID", newReport.UserID);
                    cmd.Parameters.AddWithValue("@LocationID", newReport.LocationID ?? (object)DBNull.Value); // Handle null LocationID
                    cmd.Parameters.AddWithValue("@FeedbackText", newReport.FeedbackText);
                    cmd.Parameters.AddWithValue("@CreatedAt", newReport.CreatedAt);
                    cmd.Parameters.AddWithValue("@UpdatedAt", newReport.UpdatedAt);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Report Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding report to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception or handle it as needed
                Console.WriteLine($"Error adding report to the database: {ex.Message}");

                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                    DateTime.Now,
                    "AddReport ERROR",
                    LoggedInUser.UserName,
                    Thread.CurrentThread.ManagedThreadId,
                    LoggedInUser.UserID, // Replace with the actual method to get the current user ID
                    Environment.MachineName,
                    "1.0", // Replace with your actual application version
                    "An error occurred.",
                    ex.Message,
                    ex.StackTrace,
                    "Additional information if needed."
                );

                AppLogDL.AddLogException(logEntry);
                return false;

            }
        }



    }
}
