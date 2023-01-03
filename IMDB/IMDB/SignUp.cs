using System;
using System.Windows.Forms;

namespace IMDB
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
            loginForm.Left = this.Left;
            loginForm.Top = this.Top;
            loginForm.Size = this.Size;

            //this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string lastName = txtFamilyName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            try
            {
                UserManager.addUser(userName, name, lastName, phoneNumber, email, password);

                MessageBox.Show("register was successful!", "Registraition", MessageBoxButtons.OK);

                MainPage mainPage = new MainPage();
                this.Hide();
                mainPage.Show();
                mainPage.Left = this.Left;
                mainPage.Top = this.Top;
                mainPage.Size = this.Size;

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
    }
}
