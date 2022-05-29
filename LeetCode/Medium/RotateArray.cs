//Runtime: 217 ms, faster than 55.11% of C# online submissions for Rotate Array.
//Memory Usage: 49.1 MB, less than 82.08% of C# online submissions for Rotate Array.

namespace LeetCode.Easy
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            nums.Skip(nums.Length - k).Take(k)
                .Concat(nums.Take(nums.Length - k))
                .ToArray()
                .CopyTo(nums, 0);
        }
    }
}
