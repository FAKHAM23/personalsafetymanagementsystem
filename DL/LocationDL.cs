using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using GMap.NET;

namespace WomanSafety.DL
{
    class LocationDL
    {
        /*public static PointLatLng GetLocationCoordinates(int locationId)
        {
            try
            {
                using (SqlConnection connection = Configuration.getInstance().getConnection())
                {
                    string query = "SELECT Latitude, Longitude FROM Location WHERE LocationID = @LocationId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@LocationId", locationId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                double latitude = Convert.ToDouble(reader["Latitude"]);
                                double longitude = Convert.ToDouble(reader["Longitude"]);

                                return new PointLatLng(latitude, longitude);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving location coordinates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception if needed
            }

            // Return a default location or handle the case where the location is not found
            return new PointLatLng(0, 0);
        }
*/

        public static PointLatLng GetLocationCoordinates(int locationId)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT Latitude, Longitude FROM Location WHERE LocationID = @LocationId", con);
                cmd.Parameters.AddWithValue("@LocationId", locationId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                DataRow row = dataSet.Tables[0].Rows[0];

                double latitude = Convert.ToDouble(row["Latitude"]);
                double longitude = Convert.ToDouble(row["Longitude"]);

                return new PointLatLng(latitude, longitude);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving location coordinates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the exception if needed
            }

            // Return a default location or handle the case where the location is not found
            return new PointLatLng(0, 0);
        }



    }
}
