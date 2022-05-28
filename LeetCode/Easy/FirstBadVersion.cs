namespace LeetCode.Easy
{
    public class FirstBadVersion
    {
        public int FindFirstBadVersion(int n)
        {
            var left = 0;
            var right = n;
            while (left != right)
            {
                Console.WriteLine(left + "   " + right);
                if (!IsBadVersion((right + left) / 2))
                    left = (right + left) / 2 + 1;
                else
                    right = (right + left) / 2;
            }
            if (IsBadVersion(left))
                return left;
            Console.WriteLine(left + "   " + right);
            return -1;
        }


        private bool IsBadVersion(int n)
        {
            return n >= 1;
        }
    }
}
