using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSVReader
{
    public class CsvFileReader
    {
        public List<string> ReadFromFile()
        {
            int i = 0;
            List<string> ListOfStrings = new List<string>();
            using (StreamReader streamReader = new StreamReader(@"../../NextGenBarry.csv"))
            {
                while (streamReader.EndOfStream == false)
                {
                    ListOfStrings.Add(streamReader.ReadLine());
                    //Console.WriteLine(ListOfStrings[i]);
                    i++;
                }
            }
            return ListOfStrings;
        }
    }
}
