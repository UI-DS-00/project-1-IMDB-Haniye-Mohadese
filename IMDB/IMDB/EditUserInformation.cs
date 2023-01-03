using System;
using System.Windows.Forms;

namespace IMDB
{
    public partial class EditUserInformation : Form
    {
        public EditUserInformation()
        {
            InitializeComponent();
        }

        private void EditUserInformation_Load(object sender, EventArgs e)
        {
            int userId = LoginManager.findUserLogin();
            txtUserName.Text = UserManager.userList[userId].UserName;
            txtName.Text = UserManager.userList[userId].Name;
            txtFamilyName.Text = UserManager.userList[userId].LastName;
            txtPhoneNumber.Text = UserManager.userList[userId].PhoneNumber;
            txtEmail.Text = UserManager.userList[userId].Email;
            txtPassword.Text = UserManager.userList[userId].Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtFamilyName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            try
            {

                EditUserManager.editUser(userName, name, lastName, phoneNumber, email, password);

                MessageBox.Show("Edit was successful!", "Registraition", MessageBoxButtons.OK);

                int userId = LoginManager.findUserLogin();
                UserManager.userList[userId].UserName = userName;
                UserManager.userList[userId].Name = name;
                UserManager.userList[userId].LastName = lastName;
                UserManager.userList[userId].PhoneNumber = phoneNumber;
                UserManager.userList[userId].Email = email;
                UserManager.userList[userId].Password = password;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile();
            this.Hide();
            userProfile.Show();
            userProfile.Left = this.Left;
            userProfile.Top = this.Top;
            userProfile.Size = this.Size;
        }

    }
}
