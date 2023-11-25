using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomanSafety.BL;

namespace WomanSafety.DL
{
    class AppLogDL
    {
        public static void AddLogException(AppLogBL log)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO AppLog (Timestamp, LogLevel, Logger, ThreadID, UserID, MachineName, AppVersion, Message, ExceptionDetails, StackTrace, AdditionalInfo) VALUES (@Timestamp, @LogLevel, @Logger, @ThreadID, @UserID, @MachineName, @AppVersion, @Message, @ExceptionDetails, @StackTrace, @AdditionalInfo)", con))
                {
                    cmd.Parameters.AddWithValue("@Timestamp", log.Timestamp);
                    cmd.Parameters.AddWithValue("@LogLevel", log.LogLevel);
                    cmd.Parameters.AddWithValue("@Logger", log.Logger);
                    cmd.Parameters.AddWithValue("@ThreadID", log.ThreadID);
                    cmd.Parameters.AddWithValue("@UserID", log.UserID);
                    cmd.Parameters.AddWithValue("@MachineName", log.MachineName);
                    cmd.Parameters.AddWithValue("@AppVersion", log.AppVersion);
                    cmd.Parameters.AddWithValue("@Message", log.Message);
                    cmd.Parameters.AddWithValue("@ExceptionDetails", log.ExceptionDetails);
                    cmd.Parameters.AddWithValue("@StackTrace", log.StackTrace);
                    cmd.Parameters.AddWithValue("@AdditionalInfo", log.AdditionalInfo);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Log the exception to a different location, as logging itself failed
                Console.WriteLine($"Error logging exception: {ex.Message}");
            }
        }

    }
}
