using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class LineToList
    {
        public List<List<string>> CreateListOfLineLists()
        {
            int i = 0;
            CsvFileReader csvFileReader = new CsvFileReader();
            List<string>ListToSeparate = csvFileReader.ReadFromFile();
            List<List<string>> ListOfLists = new List<List<string>>();
            foreach (string Line in ListToSeparate)
            {
                ListOfLists.Add( Line.Split(',').ToList());
                //Console.WriteLine(ListOfLists[i]);
                i++;
            }
            return ListOfLists;
        }






    }

    internal class Line

    {
    }
}
