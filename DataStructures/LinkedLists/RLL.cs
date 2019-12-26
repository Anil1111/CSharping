namespace DataStructures.LinkedLists
{
    class RLinkList
    {
        private int data;
        private RLinkList next;
        public RLinkList()
        {
            data = 0;
            next = null;
        }

        public RLinkList(int value)
        {
            data = value;
            next = null;
        }

        public RLinkList InsertNext(int value)
        {
            RLinkList node = new RLinkList(value);
            if (this.next == null)
            {
                // Easy to handle
                node.next = null; // already set in constructor
                this.next = node;
            }

            else
            {
                // Insert in the middle
                RLinkList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }

        public int DeleteNext()
        {
            if (next == null)
                return 0;
            RLinkList node = this.next;
            this.next = this.next.next;  // can be NULL here
            node = null;
            return 1;
        }

        public void Traverse(RLinkList node)
        {
            if (node == null)
                node = this;
            System.Console.WriteLine("\n\nTraversing in Forward Direction\n\n");
            while (node != null)
            {
                System.Console.WriteLine(node.data);
                node = node.next;
            }
        }

        public RLinkList Reverse_With_Bubble(RLinkList head)
        {
            RLinkList testnode = null;
            if (head == null)
                return head;
            while (true)
            {
                RLinkList p = head;
                if (p.next == testnode)
                    break;
                while (true)
                {
                    int temp = p.data;
                    p.data = p.next.data;
                    p.next.data = temp;
                    p = p.next;
                    if (p.next == testnode)
                    {
                        testnode = p;
                        break;
                    }
                }
            }
            return head;

        }

        public RLinkList Reverse(RLinkList head)
        {
            if (head == null)
                return head;
            RLinkList cp = head;
            RLinkList prev = null;
            while (cp != null)
            {
                RLinkList next = cp.next;
                cp.next = prev;
                prev = cp;
                cp = next;
            }
            head = prev;
            return head;
        }

        public RLinkList Reverse_with_copy(RLinkList head)
        {
            RLinkList p = head;
            RLinkList newhead = null;
            while (true)
            {
                if (p == null)
                    return newhead;
                RLinkList newnode = new RLinkList(p.data);
                newnode.next = newhead;
                newhead = newnode;
                p = p.next;

            }

        }

    }

}