using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{   //https://www.tutorialsteacher.com/csharp/csharp-indexer
    class Indexer
    {
        public void IndexerMethod()
        {
            StringDataStore strStore = new StringDataStore();

            strStore[0] = "One";
            strStore[1] = "Two";
            strStore[2] = "Three";
            strStore[3] = "Four";

            for (int i = 0; i < 10; i++)
                Console.WriteLine(strStore[i]);
        }
    }

    class StringDataStore
    {

        private string[] strArr = new string[10]; // internal data storage

        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                return strArr[index];
            }

            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("Cannot store more than 10 objects");

                strArr[index] = value;
            }
        }
    }
}
