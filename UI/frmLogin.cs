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
using WomanSafety.BL;
using WomanSafety.DL;

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
            //string PasswordtoHash = PasswordHasher.HashPassword(password);
            //Console.WriteLine(PasswordtoHash);
            UserBL UserToFind = new UserBL(userName, password);
            int RoleId = UserDL.FindUser(UserToFind);
            //frmLogin LoginPage = new frmLogin();
            this.Hide();

            if (RoleId == 2)
            {
                // Show the frmUserHome form
                using (frmUserHome userHomeForm = new frmUserHome())
                {
                    userHomeForm.ShowDialog();
                    Console.WriteLine("User Found!");
                }
            }
            else if (RoleId == 1)
            {
                Console.WriteLine("Admin Found!");
            }
            /*else
            {
                Console.WriteLine("No User Found!");
                MessageBox.Show("No User Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
