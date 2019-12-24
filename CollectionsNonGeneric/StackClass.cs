using System;
using System.Collections; //this is mandatory for non-generic Collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class StackClass
    {
        public void StackMethodNumbers()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(11);
            stack.Push(13);
            stack.Push(14);

            Console.WriteLine(stack.Peek());

            //for (int i = stack.Count; i < i - 1; i++)
            //{
            //    Console.WriteLine(stack.GetEnumerator().MoveNext());
            //    Console.WriteLine(stack.GetEnumerator().Current);
            //    Console.WriteLine(stack.GetEnumerator().GetHashCode());
            //}


            for (int i = 0; i < 4; i++)
                Console.WriteLine(stack.Pop());
        }
        public void StackMethodStrings()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Kanna");
            stack.Push("Reddy");
            stack.Push("Hello");
            stack.Push("Mr");

            Console.WriteLine(stack.Peek());
            foreach (string s in stack)
                Console.WriteLine(s);
        }
    }
}
