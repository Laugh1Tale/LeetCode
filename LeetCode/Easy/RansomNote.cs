//Runtime: 119 ms, faster than 40.04% of C# online submissions for Ransom Note.
//Memory Usage: 39.4 MB, less than 95.63% of C# online submissions for Ransom Note.

namespace LeetCode.Easy
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var dict1 = ransomNote.GroupBy(x => x)
              .ToDictionary(x => x.Key, y => y.Count());
            var dict2 = magazine.GroupBy(x => x)
              .ToDictionary(x => x.Key, y => y.Count());
            foreach (var e in dict1)
                if (!dict2.ContainsKey(e.Key) || dict2[e.Key] < e.Value)
                    return false;
            return true;
        }
    }
}
