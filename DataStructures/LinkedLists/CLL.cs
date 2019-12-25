using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedLists
{
    class SLinkCircularList
    {
        private int data;
        private SLinkCircularList next;

        public SLinkCircularList()
        {
            data = 0;
            next = this;
        }

        public SLinkCircularList(int value)
        {
            data = value;
            next = this;
        }

        public SLinkCircularList InsertNext(int value)
        {
            SLinkCircularList node = new SLinkCircularList(value);
            if (this.next == this) // only one node in the circular list
            {

                // Easy to handle, after the two lines of executions,
                // there will be two nodes in the circular list
                node.next = this;
                this.next = node;
            }

            else

            {
                // Insert in the middle
                SLinkCircularList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }



        public int DeleteNext()
        {
            if (this.next == this)
            {
                System.Console.WriteLine("\nThe node can not be deleted as there is only one node in the circular list");
                return 0;
            }
            SLinkCircularList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }

        public void Traverse()
        {
            Traverse(this);
        }

        public void Traverse(SLinkCircularList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");
            SLinkCircularList startnode = node;
            do
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
            while (node != startnode);
        }



        public int GetNumberOfNodes()
        {
            return GetNumberOfNodes(this);
        }

        public int GetNumberOfNodes(SLinkCircularList node)
        {
            if (node == null)
                node = this;
            int count = 0;
            SLinkCircularList startnode = node;

            do
            {
                count++;
                node = node.next;
            }
            while (node != startnode);
            System.Console.WriteLine("\nCurrent Node Value: " + node.data.ToString());
            System.Console.WriteLine("\nTotal nodes in Circular List: " + count.ToString());
            return count;

        }

    }

}