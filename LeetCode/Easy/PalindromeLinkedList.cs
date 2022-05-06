//Runtime: 361 ms, faster than 44.11% of C# online submissions for Palindrome Linked List.
//Memory Usage: 56.2 MB, less than 25.29% of C# online submissions for Palindrome Linked List.

namespace LeetCode
{
    public class PalindromeLinkedList
    {
        private LinkedList<int> nodes = new LinkedList<int>();

        public bool IsPalindrome(LinkedListNode<int> head)
        {
            while (head.Next != null)
            {
                nodes.AddLast(head.Value);
                head = head.Next;
            }
            nodes.AddLast(head.Value);
            while (nodes.Count != 0)
            {
                if (nodes.Last.Value == nodes.First.Value)
                {
                    nodes.RemoveFirst();
                    if (nodes.Count == 0)
                        break;
                    nodes.RemoveLast();
                }
                else return false;
            }
            return true;
        }
    }
}
