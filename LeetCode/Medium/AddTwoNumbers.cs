//Runtime: 101 ms, faster than 90.73% of C# online submissions for Add Two Numbers.
//Memory Usage: 49.1 MB, less than 14.73% of C# online submissions for Add Two Numbers.

namespace LeetCode.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode next;


        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


    public class AddTwoNumbers
    {
        public ListNode Add(ListNode l1, ListNode l2)
        {
            int transfer = 0;
            ListNode s = new ListNode(0);
            ListNode previous = s;

            while (l1 != null || l2 != null || transfer == 1)
            {
                int sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + transfer;
                transfer = sum < 10 ? 0 : 1;
                previous.next = new ListNode(sum % 10);
                previous = previous.next;

                if (l1 != null)
                    l1 = l1.next;

                if (l2 != null)
                    l2 = l2.next;
            }

            return s.next;
        }
    }
}
