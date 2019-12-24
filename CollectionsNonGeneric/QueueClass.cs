using System;
using System.Collections;  //this is mandatory for non-generic Collections
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsNonGeneric
{
    class QueueClass
    {
        public void QueueMethod()
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(102);
            queue.Enqueue(105);

            //foreach (Queue queue1 in queue)  //foreach is not possible unless we have Generic placeholder for queue
            //Console.WriteLine(queue1);

            //for printing all the values in queue you have to configure by using number of elements in it
            Console.WriteLine("Peek: " + queue.Peek());


            for (int i = 0; i < 3; i++)
                Console.WriteLine(queue.Dequeue());
        }

        public void QueueMethodGeneric()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(100);
            queue.Enqueue(102);
            queue.Enqueue(105);

            foreach (int i in queue)//foreach is not possible unless we have Generic placeholder for queue
                Console.WriteLine(i);
        }
    }
}
