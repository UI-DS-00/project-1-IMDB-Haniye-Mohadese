using IMDB;
using MySqlConnector;
using System.Data.SqlClient;
using System;

namespace IMDBP
{
    class DBConnect
    {
        private static MySqlConnection connection;

        public DBConnect()
        {
            Initialize();
        }

        public void Initialize()
        {
            string connetionString;
            connetionString = "datasource=localhost; username=root; password=@3084314; database=imdb";
            connection = new MySqlConnection(connetionString);
        }

        //open connection to database 
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection 
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Insert(Person person)
        {
            // string query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')" 

            int number = 2;
            string nConst = person.NConst;
            string primaryName = person.PrimaryName;
            string birthYear = person.BirthYear;
            string deathYear = person.DeathYear;
            string primaryProfession = person.PrimaryProfession;
            string knownForTitles = person.KnownForTitles;
            string linkImage = person.LinkImage;


            // string query = string.Format("INSERT INTO name.basics (`number`, nconst, primaryName, birthYear, deathYear, primaryProfession, knownForTitles, `poster_path`) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})",number,nConst,primaryName,birthYear,deathYear,primaryProfession,knownForTitles,linkImage); 

            string query = string.Format("INSERT INTO name.basics (`number`, nconst, primaryName, birthYear, deathYear, primaryProfession, knownForTitles, `poster_path`) VALUES ({0},{1},{2},{3},{4},{5},{6},{7})", number, nConst, primaryName, birthYear, deathYear, primaryProfession, knownForTitles, linkImage);

            if (this.OpenConnection() == true)
            {
                // MySqlCommand cmd = new("INSERT INTO 'name.basics' values(@number, @nconst, @primaryName, @birthYear, @deathYear, @primaryProfession, @knownForTitles,  @poster_path ", connection); 

                MySqlCommand cmd = new MySqlCommand(query, connection);


                //Execute command 
                cmd.ExecuteNonQuery();

                //close connection 
                this.CloseConnection();
            }

        }

    }
}