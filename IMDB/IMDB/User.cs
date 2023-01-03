using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    public class User
    {
        public Movie[] watchList = new Movie[100];
        public FavoriteList[] allFavoriteLists = new FavoriteList[10];//only 10 favorite lists are allowed for user
        private static int lastUserId = 0;
        private int id;
        private string name;
        private string lastName;
        private string userName;
        private string password;
        private string email;
        private string phoneNumber;
        private bool isLogin = false;

        public User(string name, string lastName, string userName, string password, string email, string phoneNumber)
        {
            id = lastUserId++;
            Name = name;
            LastName = lastName;
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public string Name { get { return name; } set { name = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public int Id { get { return id; } set { id = value; } }
        public bool IsLogin { get { return isLogin; } set { isLogin = value; } }
    }
}
