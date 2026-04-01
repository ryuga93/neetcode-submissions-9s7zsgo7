public class Solution {
    public string MinWindow(string s, string t)
    {
        if (t.Length == 0)
        {
            return "";
        }

        var frequencyT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach (var c in t)
        {
            if (!frequencyT.TryAdd(c, 1))
            {
                frequencyT[c]++;
            }
        }

        var have = 0;
        var need = frequencyT.Count;
        var left = 0;
        int[] result = { -1, -1 };
        var resultLength = int.MaxValue;

        for (var right = 0; right < s.Length; right++)
        {
            var c = s[right];
            if (!window.TryAdd(c, 1))
            {
                window[c]++;
            }

            if (frequencyT.ContainsKey(c) && window[c] == frequencyT[c])
            {
                have++;
            }

            while (have == need)
            {
                if (right - left + 1 < resultLength)
                {
                    resultLength = right - left + 1;
                    result[0] = left;
                    result[1] = right;
                }

                var leftChar = s[left];
                window[leftChar]--;

                if (frequencyT.ContainsKey(leftChar) && window[leftChar] < frequencyT[leftChar])
                {
                    have--;
                }

                left++;
            }
        }

        return resultLength == int.MaxValue ? "" : s.Substring(result[0], resultLength);
    }
}
