public class Solution {
    public string LongestPalindrome(string s)
    {
        var resultIndex = 0;
        var resultLength = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var right = i;
            var left = i;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > resultLength)
                {
                    resultIndex = left;
                    resultLength = right - left + 1;
                }

                left--;
                right++;
            }

            left = i;
            right = i + 1;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > resultLength)
                {
                    resultIndex = left;
                    resultLength = right - left + 1;
                }

                left--;
                right++;
            }
        }

        return s.Substring(resultIndex, resultLength);
    }
}
