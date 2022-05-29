//Runtime: 221 ms, faster than 54.35% of C# online submissions for Squares of a Sorted Array.
//Memory Usage: 49.1 MB, less than 36.55% of C# online submissions for Squares of a Sorted Array.

namespace LeetCode.Easy
{
    public class SquaresOfASortedArray
    {
        public int[] MakeSquaresOfASortedArray(int[] nums) =>
            nums.Select(x => x * x).OrderBy(x => x).ToArray();
    }
}
