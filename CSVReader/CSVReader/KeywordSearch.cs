using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class KeywordSearch
    {

        public void FindKeywordInList(string keywordToFind)
        {            
            LineToList lineToList = new LineToList();
            List<List<string>> ListOfLists = lineToList.CreateListOfLineLists();

            foreach (List<string> LineList in ListOfLists )
            {
                for (int i = 0; i < LineList.Count; i++)
                {
                    if (LineList[i] == keywordToFind)
                    {
                        foreach (string item in LineList)
                        {
                            Console.Write(item + ", ");
                        }
                    }
                }
            }
        }
    }
}
