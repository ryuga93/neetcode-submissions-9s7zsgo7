public class Solution {
    public int UniquePaths(int m, int n)
    {
        int[] noOfPathsPerRow = new int[n];
        Array.Fill(noOfPathsPerRow, 1);

        for (var i = m - 2; i >= 0; i--)
        {
            for (var j = n - 2; j >= 0; j--)
            {
                noOfPathsPerRow[j] = noOfPathsPerRow[j] + noOfPathsPerRow[j + 1];
            }
        }

        return noOfPathsPerRow[0];
    }
}
