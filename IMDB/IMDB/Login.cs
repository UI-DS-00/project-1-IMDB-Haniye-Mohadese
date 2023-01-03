using System;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Login : Form
    {
        public Login()
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

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
            signUp.Left = this.Left;
            signUp.Top = this.Top;
            signUp.Size = this.Size;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (LoginManager.findUserLogin() != -1)
            {
                MessageBox.Show("You have Already Loggedin!", "Login", MessageBoxButtons.OK);
            }

            else
            {
                string userName = txtUserName.Text;
                string password = txtPassword.Text;

                try
                {
                    LoginManager.checkUser(userName, password);

                    MessageBox.Show("Login was successful!", "Login", MessageBoxButtons.OK);

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
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';

        }
    }
}
