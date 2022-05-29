//Runtime: 106 ms, faster than 58.05% of C# online submissions for Search Insert Position.
//Memory Usage: 37.7 MB, less than 72.43% of C# online submissions for Search Insert Position.

namespace LeetCode.Easy
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums[nums.Length - 1] < target)
                return nums.Length;
            var left = 0;
            var right = nums.Length - 1;
            while (left != right)
            {
                if (nums[(right + left) / 2] < target)
                    left = (right + left) / 2 + 1;
                else
                    right = (right + left) / 2;
            }
            return left;
        }
    }
}
