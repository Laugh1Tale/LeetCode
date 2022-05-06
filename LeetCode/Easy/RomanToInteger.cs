//Runtime: 84 ms, faster than 71.09% of C# online submissions for Roman to Integer.
//Memory Usage: 36.8 MB, less than 72.62% of C# online submissions for Roman to Integer.

namespace LeetCode
{
    public class RomanToInteger
    {
        private Dictionary<char, int> romanLetters = new() { 
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            int intNumber = romanLetters[s[s.Length - 1]];
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (romanLetters[s[i]] < romanLetters[s[i + 1]])
                    intNumber -= romanLetters[s[i]];
                else
                    intNumber += romanLetters[s[i]];
            }
            return intNumber;
        }
    }
}
