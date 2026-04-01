public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var numRight = numbers[right];
            var numLeft = numbers[left];
            var sum = numLeft + numRight;
            
            if (sum == target)
            {
                return new []{left + 1, right + 1};
            }
            
            if (sum > target)
            {
                right--;
                continue;
            }

            if (sum < target)
            {
                left++;
            }
        }

        return new []{left + 1, right + 1};
    }
}
