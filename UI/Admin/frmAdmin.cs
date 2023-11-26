using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using WomanSafety.DL;
using WomanSafety.BL;
using System.Threading;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace WomanSafety.UI.Admin
{
    public partial class frmAdmin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        //public UserBL LoggedInUser { get; set; }

        // Create an Temporary instance 
        public UserBL LoggedInUser = new UserBL(2, "Fahad", "22221111", 4);
        public frmAdmin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            /*materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);*/
            


        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalSafetyDatabaseDataSet2.LanguageSupport' table. You can move, or remove it, as needed.
            this.languageSupportTableAdapter.Fill(this.personalSafetyDatabaseDataSet2.LanguageSupport);
            // TODO: This line of code loads data into the 'personalSafetyDatabaseDataSet2.Report' table. You can move, or remove it, as needed.
            // Modify the select query with a WHERE clause
            // Add the parameter and set its value
            //dgvAdminReport.DataSource= ReportDL.GetReportsByUser(LoggedInUser);

            this.reportTableAdapter.Fill(this.personalSafetyDatabaseDataSet2.Report);
            AdminHomeLoad(); 

        }
        private void AdminHomeLoad()
        {
            int Count = UserDL.GetUserCount(LoggedInUser);
            int DeletedUserCount = UserDL.GetDeletedUserCount(LoggedInUser);

            if (Count == 0)
            {
                lblCountUser.Text = "No User!";
            }
            else if (Count == -1)
            {
                lblCountUser.Text = "Exception Occured!";
            }
            else
            {
                lblCountUser.Text = Count.ToString();
            }
            if (DeletedUserCount == 0)
            {
                lblDelUser.Text = "No Deleted User!";
            }
            else if (DeletedUserCount == -1)
            {
                lblDelUser.Text = "Exception Occured!";
            }
            else
            {
                lblDelUser.Text = DeletedUserCount.ToString();
            }
        }

        private void btnAdminReport_Click(object sender, EventArgs e)
        {
            try
            {
                int? LocationId = null;
                string feedbackText = txtAdminReport.Text;
                if (feedbackText == "")
                {
                    throw new Exception("Feedback text cannot be null.");
                }

                ReportBL NewReport = new ReportBL(LoggedInUser.UserID, LocationId, feedbackText, DateTime.Now, DateTime.Now);
                ReportDL.AddReport(NewReport, LoggedInUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding report to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception or handle it as needed
                Console.WriteLine($"Error adding report to the database: {ex.Message}");

                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                    DateTime.Now,
                    "btnAdminReport ERROR",
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
                

            }

            //dgvAdminReport.DataSource = ReportDL.GetReportsByUser(LoggedInUser);
            this.reportTableAdapter.Fill(this.personalSafetyDatabaseDataSet2.Report);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                string accountSid = "ACb710e8dba2ebaaa3d6b4d0725fa1eb2e";
                string authToken = "d57b9dbddda0c31820cf640ebcde7332";

                TwilioClient.Init(accountSid, authToken);

                

                // Compose the message
                /*string messageBody = $"{LoggedInUser.UserName} is in danger at location: {liveLocation.Lat}, {liveLocation.Lng}";*/
                string messageBody = txtAdminMessage.Text;
                if (messageBody=="")
                {
                    throw new Exception("Message Body can not be null!");
                }

                // The WhatsApp number to send the message to (replace with your target number)
                string toPhoneNumber = "+923448657308";  // Replace with the target WhatsApp number

                // Send the WhatsApp message
                var message = MessageResource.Create(
                    body: messageBody,
                    from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),  // Twilio sandbox number
                    to: new Twilio.Types.PhoneNumber($"whatsapp:{toPhoneNumber}")
                );

                MessageBox.Show("WhatsApp message sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending WhatsApp message: {ex.Message}");
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "btnUnSafe ERROR",
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
            }
        }


        private void rdoOrangeThemeA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOrangeThemeA.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange900, Primary.Orange500, Accent.Orange200, TextShade.WHITE);
        }

        private void rdoGreenThemeA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoGreenThemeA.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.Green200, TextShade.WHITE);
        }

        private void rdoBlueThemeA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBlueThemeA.Checked)
                materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        private void swhThemeA_CheckedChanged(object sender, EventArgs e)
        {
            if (swhThemeA.Checked)
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            else
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }






    }
}
