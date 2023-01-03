﻿using System.Text.RegularExpressions;

namespace IMDB
{
    public class UserManager
    {
        public static User[] userList = new User[100];

        public static void addUser(string userName, string name, string lastName, string phoneNumber, string email, string password)
        {
            if (userName == "" || name == "" || lastName == "" || phoneNumber == "" || email == "" || password == "")
            {
                throw new InvalidEmptyInput("Fill All Boxes!");
            }

            if (userList[0] != null)
            {
                for (int i = 0; i < userList.Length; ++i)
                {
                    if (userList[i].UserName.Equals(userName))
                    {
                        throw new InvalidUserName("This userName Has been selected!");
                    }
                }
            }

            Regex phoneReg = new Regex("^(0)(9)\\d{9}$");
            if (!phoneReg.IsMatch(phoneNumber))
            {
                throw new InvalidPhoneNumber("Invalid PhoneNumber!");
            }

            Regex emailReg = new Regex("^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$");
            if (!emailReg.IsMatch(email))
            {
                throw new InvalidEmail("Invalid Email!");
            }

            User user = new User(userName, name, lastName, phoneNumber, email, password);

            userList[user.Id] = user;

        }

    }
}
