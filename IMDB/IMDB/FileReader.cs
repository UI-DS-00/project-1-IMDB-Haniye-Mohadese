using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB
{
    internal class FileReader
    {
        public List<Person> fileReader(List<Person> peopleList)
        {
            StreamReader sr = new StreamReader(@"name.basics1-200.tsv");

            string line;
            string[] column = new string[7];
            int i = 0;

            while ((line = sr.ReadLine()) != null)
            {
                column = line.Split('\t');
                peopleList[i] = new Person(column[0], column[1], column[2], column[3], column[4], column[5], column[6]);
                i++;
            }
            return peopleList;
        }
    }
}
