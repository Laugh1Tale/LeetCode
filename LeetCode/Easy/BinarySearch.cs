//Runtime: 154 ms, faster than 54.14% of C# online submissions for Binary Search.
//Memory Usage: 41.5 MB, less than 74.84% of C# online submissions for Binary Search

namespace LeetCode.Easy
{
    public class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while (left != right)
            {
                if (nums[(right + left) / 2] < target)
                    left = (right + left) / 2 + 1;
                else
                    right = (right + left) / 2;
            }
            if (nums[left] == target)
                return left;
            return -1;
        }
    }
}
