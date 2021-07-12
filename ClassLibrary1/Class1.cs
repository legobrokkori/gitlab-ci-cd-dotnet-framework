using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public bool IsCercle(ListNode head)
        {

            var slow = head;
            var fast = head;

            while (fast != null)
            {
                if (fast.next == null || fast.next.next == null)
                {
                    return false;
                }

                if (slow == fast)
                {
                    break;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
