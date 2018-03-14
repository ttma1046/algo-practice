using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        class Node
        {
            public int Data;
            public Node Next;
        }

        static Node Reverse(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node result = null;
            Node previous = null;
            Node current = head;

            while (current != null)
            {
                Node next = current.Next;
                if (next == null)
                {
                    result = current;
                }

                current.Next = previous;
                previous = current;
                current = next;
            }

            return result;
        }
    }

}
