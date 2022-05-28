//Runtime: 21 ms, faster than 90.39% of C# online submissions for First Bad Version.
//Memory Usage: 25.3 MB, less than 62.76% of C# online submissions for First Bad Version.

namespace LeetCode.Easy
{
    public class FirstBadVersion
    {
        public int FindFirstBadVersion(int n)
        {
            int left = 1, right = n;

            while (left < right)
                if (IsBadVersion(left + (right - left) / 2))
                    right = left + (right - left) / 2;
                else
                    left = left + (right - left) / 2 + 1;
            return left;
        }


        private bool IsBadVersion(int n) => n >= 1;
    }
}
