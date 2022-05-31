//Runtime: 269 ms, faster than 71.23% of C# online submissions for Reverse String.
//Memory Usage: 46.8 MB, less than 98.00% of C# online submissions for Reverse String.


namespace LeetCode.Easy
{
    public class ReverseString
    {
        public void MakeReversedString(char[] s)
        {
            //O(1) extra memory
            int left = 0, right = s.Length - 1;

            while (left < right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++; right--;
            }
        }
        //=> s.Reverse().ToArray().CopyTo(s, 0); =)
    }
}
