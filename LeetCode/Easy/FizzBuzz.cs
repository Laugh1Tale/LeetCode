//Runtime: 179 ms, faster than 53.03% of C# online submissions for Fizz Buzz.
//Memory Usage: 46.8 MB, less than 95.82% of C# online submissions for Fizz Buzz.

namespace LeetCode.Easy
{
    public class FizzBuzz
    {
        public IList<string> DoFizzBuzz(int n)
        {
            var a = new string[n];
            for (var i = 1; i <= n; i++)
            {
                if (i % 15 == 0)
                    a[i - 1] = "FizzBuzz";
                else if (i % 3 == 0)
                    a[i - 1] = "Fizz";
                else if (i % 5 == 0)
                    a[i - 1] = "Buzz";
                else
                    a[i - 1] = i.ToString();
            }
            return a;
        }
    }
}
