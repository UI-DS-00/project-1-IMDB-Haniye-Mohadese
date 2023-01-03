using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }

        
        private void lblHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
            mainPage.Left = this.Left;
            mainPage.Top = this.Top;
            mainPage.Size = this.Size;
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            int userId = LoginManager.findUserLogin();
            txtUserName.Text = UserManager.userList[userId].UserName;
            txtName.Text = UserManager.userList[userId].Name;
            txtFamilyName.Text = UserManager.userList[userId].LastName;
            txtPhoneNumber.Text = UserManager.userList[userId].PhoneNumber;
            txtEmail.Text = UserManager.userList[userId].Email;
            txtPassword.Text = UserManager.userList[userId].Password;
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            int userId = LoginManager.findUserLogin();
            UserManager.userList[userId].IsLogin = false;

            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
            mainPage.Left = this.Left;
            mainPage.Top = this.Top;
            mainPage.Size = this.Size;
        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
