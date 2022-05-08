//Runtime: 87 ms, faster than 86.72% of C# online submissions for Richest Customer Wealth.
//Memory Usage: 37.6 MB, less than 72.11% of C# online submissions for Richest Customer Wealth.

namespace LeetCode.Easy
{
    public class RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts) =>
            accounts.Select(x => x.Sum()).Max();
    }
}
