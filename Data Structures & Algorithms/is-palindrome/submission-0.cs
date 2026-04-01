public class Solution {
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            var charLeft = s[left];
            var charRight = s[right];
            var isLeftAlphanumeric = char.IsLetterOrDigit(charLeft);
            var isRightAlphanumeric = char.IsLetterOrDigit(charRight);
            if (isLeftAlphanumeric && isRightAlphanumeric)
            {
                if (char.ToUpperInvariant(charLeft) != char.ToUpperInvariant(charRight))
                {
                    return false;
                }
                left++;
                right--;
            }
            else
            {
                if (!isLeftAlphanumeric)
                {
                    left++;
                }

                if (!isRightAlphanumeric)
                {
                    right--;
                }
            }
        }

        return true;
    }
}
