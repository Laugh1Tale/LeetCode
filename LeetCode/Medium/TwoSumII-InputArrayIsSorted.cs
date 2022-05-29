//Runtime: 186 ms, faster than 60.03% of C# online submissions for Two Sum II - Input Array Is Sorted.
//Memory Usage: 44.6 MB, less than 89.01% of C# online submissions for Two Sum II - Input Array Is Sorted.

namespace LeetCode.Medium
{
    public class TwoSumII_InputArrayIsSorted
    {
        public int[] TwoSum(int[] numbers, int target){
            var low = 0;
            var high = numbers.Length - 1;
            while (numbers[low] + numbers[high] != target)
                if (numbers[low] + numbers[high] > target) 
                    high--;
                else 
                    low++;

            return new int[] { low + 1, high + 1 };
        }
    }
}
