public class Solution {
    public bool WordBreak(string s, List<string> wordDict)
    {
        bool[] canWordBreak = new bool[s.Length + 1];
        canWordBreak[s.Length] = true;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            foreach (var word in wordDict)
            {
                if (i + word.Length <= s.Length && s.Substring(i, word.Length) == word)
                {
                    canWordBreak[i] = canWordBreak[i + word.Length];
                }

                if (canWordBreak[i])
                {
                    break;
                }
            }
        }

        return canWordBreak[0];
    }
}
