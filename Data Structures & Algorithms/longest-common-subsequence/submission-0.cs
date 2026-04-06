public class Solution {
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[,] longestSubsequenceStore = new int [text1.Length + 1, text2.Length + 1];

        for (var i = text1.Length - 1; i >= 0; i--)
        {
            for (var j = text2.Length - 1; j >= 0; j--)
            {
                if (text1[i] == text2[j])
                {
                    longestSubsequenceStore[i, j] = 1 + longestSubsequenceStore[i + 1, j + 1];
                }
                else
                {
                    longestSubsequenceStore[i, j] = Math.Max(longestSubsequenceStore[i + 1, j],
                        longestSubsequenceStore[i, j + 1]);
                }
            }
        }

        return longestSubsequenceStore[0, 0];
    }
}
