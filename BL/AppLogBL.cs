using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WomanSafety.BL
{
    class AppLogBL
    {
        public int LogID { get; set; }
        public DateTime Timestamp { get; set; }
        public string LogLevel { get; set; }
        public string Logger { get; set; }
        public int ThreadID { get; set; }
        public int? UserID { get; set; }
        public string MachineName { get; set; }
        public string AppVersion { get; set; }
        public string Message { get; set; }
        public string ExceptionDetails { get; set; }
        public string StackTrace { get; set; }
        public string AdditionalInfo { get; set; }

        public AppLogBL(DateTime timestamp, string logLevel, string logger, int threadID, int userID, string machineName, string appVersion, string message, string exceptionDetails, string stackTrace, string additionalInfo)
        {
            Timestamp = timestamp;
            LogLevel = logLevel;
            Logger = logger;
            ThreadID = threadID;
            UserID = userID;
            MachineName = machineName;
            AppVersion = appVersion;
            Message = message;
            ExceptionDetails = exceptionDetails;
            StackTrace = stackTrace;
            AdditionalInfo = additionalInfo;
        }


    }
}
