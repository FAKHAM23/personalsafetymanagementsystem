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

namespace WomanSafety
{
    public partial class frmLogin : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public frmLogin()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            LoginLeftPanel.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
            lblMain.ForeColor=Color.White;
            lblSecond.ForeColor = Color.White;
            lblMain.Font = new Font(lblMain.Font.FontFamily, 35, FontStyle.Regular);
            lblSecond.Font = new Font(lblMain.Font.FontFamily, 16, FontStyle.Regular);
            lblMain.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
            lblSecond.BackColor = materialSkinManager.ColorScheme.PrimaryColor;


        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get user input
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            // Validate user input
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var con = Configuration.getInstance().getConnection();

                // Use parameterized query to prevent SQL injection
                string query = "SELECT * FROM [User] WHERE [UserName] = @Username AND [Password] = @Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the user's role ID
                            int roleId = Convert.ToInt32(reader["RoleID"]);

                            // Successful login
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();

                            if (roleId == 2)
                            {
                                // Show the frmUserHome form
                                using (frmUserHome userHomeForm = new frmUserHome())
                                {
                                    userHomeForm.ShowDialog();
                                }
                            }
                            else
                            {

                            } 
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
