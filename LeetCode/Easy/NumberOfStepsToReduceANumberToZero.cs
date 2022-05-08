//Runtime: 21 ms, faster than 85.74% of C# online submissions for Number of Steps to Reduce a Number to Zero.
//Memory Usage: 25.2 MB, less than 71.80% of C# online submissions for Number of Steps to Reduce a Number to Zero.

namespace LeetCode.Easy
{
    public class NumberOfStepsToReduceANumberToZero
    {
        private int count = 0;

        public int NumberOfSteps(int num)
        {
            if (num == 0)
                return count;
            count++;
            return num % 2 == 0 ? NumberOfSteps(num / 2) : NumberOfSteps(num - 1);
        }
    }
}
