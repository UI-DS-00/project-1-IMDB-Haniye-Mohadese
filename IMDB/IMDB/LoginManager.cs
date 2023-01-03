namespace IMDB
{
    public class LoginManager
    {
        public static void checkUser(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new InvalidEmptyInput("Fill All Boxes!");
            }

            int check = -1;

            if (UserManager.userList[0] == null)
            {
                throw new UnAvailableUser("User Not Found");
            }

            if (UserManager.userList[0] != null)
            {

                for (int i = 0; i < UserManager.userList.Length; i++)
                {
                    if (UserManager.userList[i].UserName.Equals(username))
                    {
                        check = i;
                        UserManager.userList[i].IsLogin = true;
                        break;
                    }
                }

                if (check == -1)
                {
                    throw new UnAvailableUser("User Not Found");
                }

                if (!UserManager.userList[check].Password.Equals(password))
                {
                    throw new UnAvailableUser("Incorrect Password!");
                }
            }
        }

        public static int findUserLogin()
        {
            for (int i = 0; i < UserManager.userList.Length; i++)
            {
                if (UserManager.userList[i] != null)
                {
                    if (UserManager.userList[i].IsLogin.Equals(true))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
