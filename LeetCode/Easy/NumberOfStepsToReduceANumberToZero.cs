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
            if (num % 2 == 0)
                return NumberOfSteps(num / 2);
            else
                return NumberOfSteps(num - 1);
        }
    }
}
