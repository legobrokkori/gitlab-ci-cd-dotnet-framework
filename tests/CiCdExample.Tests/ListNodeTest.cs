using Xunit;
using ClassLibrary1;

namespace CiCdExample.Tests
{
    public class ListNodeTest
    {
        [Fact]
        public void Test1()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = head.next;

            var sol = new Solution();
            
            Assert.True(sol.IsCercle(head));
        }
    }
}
