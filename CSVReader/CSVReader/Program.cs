using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //CsvFileReader csvFileReader = new CsvFileReader();
            //LineToList lineToList = new LineToList();
            //csvFileReader.ReadFromFile();
            //lineToList.CreateListOfLineLists();
            KeywordSearch keywordSearch = new KeywordSearch();
            keywordSearch.FindKeywordInList("Marge");
            Console.ReadKey();
        }
    }
}
