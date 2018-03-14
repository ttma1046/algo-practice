using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.addtwonumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbera = new ListNode(2) {next = new ListNode(4) {next = new ListNode(3)}};
            var numberb = new ListNode(5) {next = new ListNode(6) {next = new ListNode(4)}};

            AddTwoNumbers()
        }

        public class ListNode
        {
            public int val { get; set; }
            public ListNode next { get; set; }
            public ListNode(int value)
            {
                this.val = value;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = p?.val ?? 0;
                int y = q?.val ?? 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                p = p?.next;
                q = q?.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }
}
