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
using WomanSafety.UI.Admin;
using WomanSafety.BL;
using WomanSafety.DL;
using System.Threading;

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
            UserBL UserToFind= null;
            //bool UserLoggedIn = false;
            
            try
            {

                // Get user input
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                // Validate user input
                if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                //string PasswordtoHash = PasswordHasher.HashPassword(password);
                //Console.WriteLine(PasswordtoHash);
                UserToFind = new UserBL(userName, password);
                int RoleId = UserDL.FindUser(UserToFind);
                //frmLogin LoginPage = new frmLogin();
                //
                    

                if (RoleId == 4)
                {
                    // Show the frmUserHome form
                    using (frmUserHome userHomeForm = new frmUserHome())
                    {
                        userHomeForm.LoggedInUser = UserToFind;
                        userHomeForm.ShowDialog();
                        Console.WriteLine("User Found!");
                        //UserLoggedIn = true;
                        this.Hide();
                    }
                }
                else if (RoleId == 3)
                {
                    using (frmAdmin AdminForm = new frmAdmin())
                    {
                        AdminForm.LoggedInUser = UserToFind;
                        AdminForm.ShowDialog();
                        Console.WriteLine("Admin Found!");
                        //UserLoggedIn = true;
                        this.Hide();
                    }
                }
                else
                {
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., no internet connection or API request failure
                Console.WriteLine($"Error Logging In: {ex.Message}");
                // Create an instance of AppLogBL using the constructor
                AppLogBL logEntry = new AppLogBL(
                DateTime.Now,
                "btnLogin ERROR",
                "No Username",
                Thread.CurrentThread.ManagedThreadId,
                UserToFind.UserID, // Replace with the actual method to get the current user ID
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

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGoSignup_Click(object sender, EventArgs e)
        {
            SignupPage SignUp = new SignupPage();
            SignUp.Show();
            this.Hide();
        }
    }
}
