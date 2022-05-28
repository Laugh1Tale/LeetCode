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
