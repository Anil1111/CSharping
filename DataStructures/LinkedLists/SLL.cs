using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.LinkedLists
{
    class SLinkList
    {
        private int data;
        private SLinkList next;

        public SLinkList(){
            data = 0;
            next = null;
        }

        public SLinkList(int value){
            data = value;
            next = null;
        }

        public SLinkList InsertNext(int value){
            SLinkList node = new SLinkList(value);
            if (this.next == null)
            {
                // Easy to handle
                node.next = null; // already set in constructor
                this.next = node;
            }

            else
            {
                // Insert in the middle
                SLinkList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }

        public int DeleteNext(){
            if (next == null)
                return 0;
            SLinkList node = this.next;
            this.next = this.next.next;  // can be NULL here
            node = null;
            return 1;
        }

        public void Traverse(SLinkList node){
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }

}

