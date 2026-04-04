public class Solution {
    public int NumDecodings(string s)
    {
        var currentPlusOne = 1;
        var currentPlusTwo = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var current = 0;
            if (s[i] == '0')
            {
                current = 0;
            }
            else
            {
                current = currentPlusOne;

                if (i + 1 < s.Length && (s[i] == '1' || s[i] == '2' && s[i + 1] < '7'))
                {
                    current += currentPlusTwo;
                }
            }

            currentPlusTwo = currentPlusOne;
            currentPlusOne = current;
        }

        return currentPlusOne;
    }
}

