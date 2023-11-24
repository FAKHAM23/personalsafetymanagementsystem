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
using MaterialSkin.Controls;
using System.Data.SqlClient;
using WomanSafety.UI;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.Net.Http;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;


namespace WomanSafety.UI
{
    public partial class frmUserHome : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        // Default location coordinates
        double defaultLatitude = 31.5497; // Lahore's latitude
        double defaultLongitude = 74.3436; // Lahore's longitude

        public frmUserHome()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            // Set up the Google Maps control
            gMapHome.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            // Set the API key
            GoogleMapProvider.Instance.ApiKey = "AIzaSyDEhr2LJnyoNt6wO5JUraz27F04PowVhzQ";

            // Create and configure the GMap control
            gMapHome.Dock = DockStyle.Fill;
            gMapHome.Position = new PointLatLng(defaultLatitude, defaultLongitude);
            gMapHome.Zoom = 10;
            gMapHome.MinZoom = 1;
            gMapHome.MaxZoom = 18;
            gMapHome.CanDragMap = true;
            gMapHome.AutoScroll = true;

            GetAndPrintLiveLocation();
            // Set the default location when the form is loaded
            //SetDefaultLocation();
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
                return new PointLatLng(defaultLatitude, defaultLongitude);
            }
        }

        private PointLatLng GetDroppedPinLocation()
        {
            // Replace this with your actual implementation to get the dropped pin location
            // For example, you can use a default location or the last known location
            return new PointLatLng(232, 234);
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
