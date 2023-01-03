using System;
using System.Windows.Forms;

namespace IMDB
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
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

        private void lblLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
            login.Left = this.Left;
            login.Top = this.Top;
            login.Size = this.Size;
        }

        private void lblUserProfile_Click(object sender, EventArgs e)
        {
            if (LoginManager.findUserLogin()==-1)
            {
                MessageBox.Show("Please Login!", "Login ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Login login = new Login();
                this.Hide();
                login.Show();
                login.Left = this.Left;
                login.Top = this.Top;
                login.Size = this.Size;
            }

            else
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
}
