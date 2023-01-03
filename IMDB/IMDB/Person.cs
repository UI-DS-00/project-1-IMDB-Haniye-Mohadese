using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    public class Person
    {
        public string NConst { get; set; }
        public string PrimaryName { get; set; }
        public string BirthYear { get; set; }
        public string DeathYear { get; set; }
        public string PrimaryProfession { get; set; }
        public string KnownForTitles { get; set; }
        public string linkImage { get; set; }

        public Person(string nConst, string primaryName, string birthYear, string deathYear,
            string primaryProfession, string knownForTitles, string linkImage)
        {
            NConst = nConst;
            PrimaryName = primaryName;
            BirthYear = birthYear;
            DeathYear = deathYear;
            PrimaryProfession = primaryProfession;
            KnownForTitles = knownForTitles;
            this.linkImage = linkImage;
        }
    }
}
