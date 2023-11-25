using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using WomanSafety.UI;
using WomanSafety.BL;
using WomanSafety.DL;
using WomanSafety.DL;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Net.Http;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace WomanSafety.UI
{
    public partial class frmUserHome : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        // Default location coordinates
        double defaultLatitude = 31.5497; // Lahore's latitude
        double defaultLongitude = 74.3436; // Lahore's longitude

        //public UserBL LoggedInUser { get; set; }


        // Create an Temporary instance 
        public UserBL LoggedInUser = new UserBL(1, "Hajra", "11112222", 4);




        public frmUserHome()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
            InitializeGmap(gMapHome);
            InitializeGmap(gMapRoute);

            GetAndPrintLiveLocation();
            // Set the default location when the form is loaded
            //SetDefaultLocation();
        }

        private void InitializeGmap(GMapControl gMap1)
        {
            // Set up the Google Maps control
            gMap1.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Set the API key
            GoogleMapProvider.Instance.ApiKey = "AIzaSyDEhr2LJnyoNt6wO5JUraz27F04PowVhzQ";

            // Create and configure the GMap control
            gMap1.Dock = DockStyle.Fill;
            gMap1.Position = new PointLatLng(defaultLatitude, defaultLongitude);
            gMap1.Zoom = 10;
            gMap1.MinZoom = 1;
            gMap1.MaxZoom = 18;
            gMap1.CanDragMap = true;
            gMap1.AutoScroll = true;

        }

        private async void GetAndPrintLiveLocation()
        {
            // Get live location
            PointLatLng liveLocation = await GetLiveLocationAsync();

            // Print the location to the console or any other desired output
            Console.WriteLine($"Live Location - Latitude: {liveLocation.Lat}, Longitude: {liveLocation.Lng}");
        }




        private async Task<PointLatLng> GetLiveLocationAsync()
        {
            try
            {
                // Use the Geolocation API to get the live location
                using (HttpClient client = new HttpClient())
                {
                    string apiKey = "AIzaSyDEhr2LJnyoNt6wO5JUraz27F04PowVhzQ";
                    string response = await client.GetStringAsync($"https://www.googleapis.com/geolocation/v1/geolocate?key={apiKey}");
                    JObject jsonResponse = JObject.Parse(response);
                    double latitude = jsonResponse["location"]["lat"].Value<double>();
                    double longitude = jsonResponse["location"]["lng"].Value<double>();

                    return new PointLatLng(latitude, longitude);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., no internet connection or API request failure
                Console.WriteLine($"Error getting live location: {ex.Message}");
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "ERROR",
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
                return new PointLatLng(defaultLatitude, defaultLongitude);


            }
        }

        private PointLatLng GetDroppedPinLocation()
        {
            return new PointLatLng(31.5497, 74.3436);
        }

        private void UpdateMap(PointLatLng location)
        {
            // Update the map position
            gMapHome.Position = location;
        }

        private void SetDefaultLocation()
        {
            // Set the default location when the form is loaded
            PointLatLng defaultLocation = GetDroppedPinLocation();
            UpdateMap(defaultLocation);
        }

        private void swhSendLocation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmUserHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalSafetyDatabaseDataSet2.SafetyTips' table. You can move, or remove it, as needed.
            this.safetyTipsTableAdapter.Fill(this.personalSafetyDatabaseDataSet2.SafetyTips);

        }

        private void dgvSafetyTips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell is in the "View" column
                if (e.ColumnIndex >= 0 && dgvSafetyTips.Columns[e.ColumnIndex].Name == "View")
                {
                    // Check if a valid row is clicked (not the header)
                    if (e.RowIndex >= 0 && dgvSafetyTips.Rows[e.RowIndex].Cells.Count > 1)
                    {
                        // Find the indexes of the "Title" and "Description" columns
                        int titleColumnIndex = dgvSafetyTips.Columns["Title"]?.Index ?? -1;
                        int descriptionColumnIndex = dgvSafetyTips.Columns["Description"]?.Index ?? -1;

                        // Check if the columns were found
                        if (titleColumnIndex != -1 && descriptionColumnIndex != -1)
                        {
                            string title = dgvSafetyTips.Rows[e.RowIndex].Cells[titleColumnIndex].Value?.ToString() ?? string.Empty;
                            string description = dgvSafetyTips.Rows[e.RowIndex].Cells[descriptionColumnIndex].Value?.ToString() ?? string.Empty;

                            // Split the description by newline and add numbering
                            string[] descriptionLines = description.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                            StringBuilder formattedDescription = new StringBuilder();

                            for (int i = 0; i < descriptionLines.Length; i++)
                            {
                                // Trim leading whitespace and add numbering
                                formattedDescription.AppendLine($"{descriptionLines[i].TrimStart()}");
                            }
                            txtSafetyTitle.Text = title;
                            txtSafetyTitle.Font = new Font(txtSafetyTitle.Font.FontFamily, 16, FontStyle.Bold);
                            // Set the TextBox values, starting from a new line
                            txtSafetyTip.Text = $"{title}{Environment.NewLine}{formattedDescription}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions here (e.g., log or display an error message)
                Console.WriteLine($"Error in CellClick event: {ex.Message}");

                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "ERROR",
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

        private async void btnUnsafe_Click(object sender, EventArgs e)
        {
            try
            {
                string accountSid = "ACb710e8dba2ebaaa3d6b4d0725fa1eb2e";
                string authToken = "d57b9dbddda0c31820cf640ebcde7332";

                TwilioClient.Init(accountSid, authToken);

                // Get the live location
                PointLatLng liveLocation = await GetLiveLocationAsync();

                // Compose the message
                /*string messageBody = $"{LoggedInUser.UserName} is in danger at location: {liveLocation.Lat}, {liveLocation.Lng}";*/
                string messageBody = $"Ali is in danger at location: {liveLocation.Lat}, {liveLocation.Lng}";

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
                "ERROR",
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

        private void btnLetsGo_Click(object sender, EventArgs e)
        {

        }


    }


    class RoundedButton : Button
    {
        public int rdus = 185;
        System.Drawing.Drawing2D.GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            System.Drawing.Drawing2D.GraphicsPath GraphPath = new System.Drawing.Drawing2D.GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                    Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (System.Drawing.Drawing2D.GraphicsPath GraphPath = GetRoundPath(Rect, rdus))
            {
                this.Region = new Region(GraphPath);
                using (Brush brush = new SolidBrush(Color.Red))
                {
                    e.Graphics.FillPath(brush, GraphPath);
                }
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
                this.BringToFront();
            }
            Font textFont = new Font(this.Font.FontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush textBrush = new SolidBrush(Color.White);

            // Draw text with word wrap
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Text, textFont, textBrush, Rect, stringFormat);

            // Bring the text to the front
            this.BringToFront();
        }

    }


}
