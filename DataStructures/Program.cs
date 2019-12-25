using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedLists.SLinkList node1 = new LinkedLists.SLinkList(1);
            LinkedLists.SLinkList node2 = node1.InsertNext(2);
            LinkedLists.SLinkList node3 = node2.InsertNext(3);
            LinkedLists.SLinkList node4 = node3.InsertNext(4);
            LinkedLists.SLinkList node5 = node4.InsertNext(5);
            node1.Traverse(null);
            node3.DeleteNext(); // delete the node "4"
            node2.Traverse(null);
        }
    }
}
