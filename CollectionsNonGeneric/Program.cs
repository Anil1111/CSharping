using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            HashtablesClass hashtablesClass = new HashtablesClass();
            hashtablesClass.HashtablesMethod();

            //SortedListClass sortedListClass = new SortedListClass();
            //sortedListClass.SortedListMethod();

            //ArrayLists arrayLists = new ArrayLists();
            //arrayLists.ArrayListsMethod();

            //QueueClass queueClass = new QueueClass();
            //queueClass.QueueMethod();
            //queueClass.QueueMethodGeneric();

            //StackClass stackClass = new StackClass();
            //stackClass.StackMethodNumbers();
            //stackClass.StackMethodStrings();

            Console.ReadLine();
        }
    }
}
