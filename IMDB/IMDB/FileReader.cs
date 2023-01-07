using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IMDB
{
    internal class FileReader
    {
        public static List<Person> fileReader(List<Person> peopleList)
        {
            
            var path = "name.basics1-200.tsv";
            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            for (int i = 1; i < lines.Length; ++i)
            {
                string[] column = lines[i].Split('\t');

                string nConst = column[0];
                string primaryName = column[1];
                string birthYear = column[2];
                string deathYear = column[3];
                string primaryProfession = column[4];
                string knownForTitles = column[5];
                string linkImage = column[6];

                peopleList.Add(new Person(nConst, primaryName, birthYear, deathYear, primaryProfession, knownForTitles, linkImage));

            }

            return peopleList;
        }
    }
}