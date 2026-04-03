public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        var currentMinusOne = 0;
        var currentMinusTwo = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            var current = Math.Max(nums[i] + currentMinusTwo, currentMinusOne);

            currentMinusTwo = currentMinusOne;
            currentMinusOne = current;
        }

        var maxFirst = currentMinusOne;

        currentMinusOne = 0;
        currentMinusTwo = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var current = Math.Max(nums[i] + currentMinusTwo, currentMinusOne);

            currentMinusTwo = currentMinusOne;
            currentMinusOne = current;
        }

        return Math.Max(maxFirst, currentMinusOne);
    }
}
