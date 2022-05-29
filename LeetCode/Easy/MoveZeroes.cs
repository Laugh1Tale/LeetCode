//Runtime: 218 ms, faster than 52.42% of C# online submissions for Move Zeroes.
//Memory Usage: 46.9 MB, less than 86.88% of C# online submissions for Move Zeroes.

namespace LeetCode.Easy
{
    public class MoveZeroes
    {
        public void MoveZeroesToEnd(int[] nums)
        {
            var indexes = nums.Select((value, index) => new { value, index })
                .Where(x => x.value == 0)
                .Select(x => x.index);
            var listOfNums = nums.ToList();
            var count = 0;
            foreach (var index in indexes)
            {
                listOfNums.Add(nums[index]);
                listOfNums.RemoveAt(index - count);
                count++;
            }
            listOfNums
                .ToArray()
                .CopyTo(nums, 0);
        }
    }
}
