public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char, int>();
        var left = 0;
        var maxFrequency = 0;
        var result = 0;

        for (var right = 0; right < s.Length; right++)
        {
            if (dict.ContainsKey(s[right]))
            {
                dict[s[right]]++;
            }
            else
            {
                dict[s[right]] = 1;
            }

            maxFrequency = Math.Max(maxFrequency, dict[s[right]]);

            while ((right - left + 1) - maxFrequency > k)
            {
                dict[s[left]]--;
                left++;
            }

            result = Math.Max(result, right - left + 1);
        }

        return result;
    }
}
