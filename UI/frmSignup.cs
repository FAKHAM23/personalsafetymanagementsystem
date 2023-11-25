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
using WomanSafety.BL;
using WomanSafety.DL;
using System.Threading;

namespace WomanSafety
{
    public partial class SignupPage : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public SignupPage()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200,MaterialSkin.TextShade.WHITE);

            LoginLeftPanel.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
            lblMain.ForeColor = Color.White;
            lblSecond.ForeColor = Color.White;
            lblMain.Font = new Font(lblMain.Font.FontFamily, 35, FontStyle.Regular);
            lblSecond.Font = new Font(lblMain.Font.FontFamily, 16, FontStyle.Regular);
            lblMain.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
            lblSecond.BackColor = materialSkinManager.ColorScheme.PrimaryColor;
        }

      

        private void btnSignUpBack_Click(object sender, EventArgs e)
        {
            // Open Login form 
            frmLogin Login = new frmLogin();
            Login.Show();
            // Close the current form (Form1)
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserBL NewUser = null;
            try
            {
                // Get user input
                string userName = txtUserName.Text;
                int roleId = cmbxRole.SelectedValue as int? ?? 0; // Default to 0 if null
                DateTime createdAt = DateTime.Now;
                DateTime updatedAt = DateTime.Now;

                // Validate user input
                if (string.IsNullOrWhiteSpace(userName))
                {
                    MessageBox.Show("Enter User Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (roleId == 0)
                {
                    MessageBox.Show("Select Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string enteredPassword = txtPassword.Text;
                string enteredConfirmPassword = txtConfirmPass.Text;

                if (string.IsNullOrWhiteSpace(enteredPassword) || string.IsNullOrWhiteSpace(enteredConfirmPassword))
                {
                    MessageBox.Show("Please enter the password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (enteredPassword != enteredConfirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Text = "";
                    txtConfirmPass.Text = "";
                    return;
                }
                string HashedPassword = PasswordHasher.HashPassword(enteredPassword);
                NewUser = new UserBL(userName,HashedPassword,roleId,createdAt,updatedAt);
                UserDL.AddUser(NewUser);
            
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., no internet connection or API request failure
                Console.WriteLine($"Error Logging In: {ex.Message}");
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "btnSignUp ERROR",
                txtUserName.Text,
                Thread.CurrentThread.ManagedThreadId,
                NewUser.UserID, // Replace with the actual method to get the current user ID
                Environment.MachineName,
                "1.0", // Replace with your actual application version
                "An error occurred.",
                ex.Message,
                ex.StackTrace,
                "No Additional information"
                );
                AppLogDL.AddLogException(logEntry);
            }
        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalSafetyDatabaseDataSet2.UserRole' table. You can move, or remove it, as needed.
            this.userRoleTableAdapter.Fill(this.personalSafetyDatabaseDataSet2.UserRole);

        }
    }
}
