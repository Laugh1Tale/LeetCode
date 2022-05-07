//Runtime: 167 ms, faster than 78.49% of C# online submissions for The K Weakest Rows in a Matrix.
//Memory Usage: 44.7 MB, less than 80.21% of C# online submissions for The K Weakest Rows in a Matrix.

namespace LeetCode.Easy
{
    public class TheKWeakestRowsInAMatrix
    {
        public int[] KWeakestRows(int[][] mat, int k) =>
            mat.Select((value, index) => new { value, index })
               .OrderBy(x => x.value.Sum())
               .Take(k)
               .Select(x => x.index)
               .ToArray();
    }
}
