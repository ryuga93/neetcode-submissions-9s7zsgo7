public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (s.Length == 0)
        {
            return 0;
        }

        var dict = new Dictionary<char, int>();
        var left = 0;
        var result = 0;

        for (var right = 0; right < s.Length; right++)
        {
            if (dict.ContainsKey(s[right]))
            {
                left = Math.Max(dict[s[right]] + 1, left);
            }

            dict[s[right]] = right;
            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
