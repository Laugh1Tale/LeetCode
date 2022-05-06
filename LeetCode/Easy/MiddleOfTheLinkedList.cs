//Runtime: 123 ms, faster than 30.35% of C# online submissions for Middle of the Linked List.
//Memory Usage: 36.3 MB, less than 94.38% of C# online submissions for Middle of the Linked List.

namespace LeetCode.Easy
{
    public class MiddleOfTheLinkedList
    {
        public LinkedListNode<int> MiddleNode(LinkedListNode<int> head)
        {
            var tail = head;
            var middle = head;
            while (tail != null && tail.Next != null)
            {
                tail = tail.Next.Next;
                middle = middle.Next;
            }
            return middle;
        }
    }
}
