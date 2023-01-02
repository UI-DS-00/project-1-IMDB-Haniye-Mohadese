using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDBTeamWork
{
    public class Movie
    {
        private string tconst;
        private string titleType;
        private string primaryTitle;
        private string originalTitle;
        private int isAdult;//0 = false 1= true
        private string startYear;
        private string endYear;
        private string runtimeMinutes;
        private string[] genres = new String[3];//includes up to three genres

        public Movie(string tconst, string titleType, string primaryTitle, string originalTitle, int isAdult, string startYear, string endYear, string runtimeMinutes)
        {
            this.tconst = tconst;
            this.titleType = titleType;
            this.primaryTitle = primaryTitle;
            this.originalTitle = originalTitle;
            this.isAdult = isAdult;
            this.startYear = startYear;
            this.endYear = endYear;
            this.runtimeMinutes = runtimeMinutes;
        }
    }
}
