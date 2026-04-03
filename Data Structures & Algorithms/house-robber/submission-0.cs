public class Solution {
    public int Rob(int[] nums) {
        var currentMinusOne = 0;
        var currentMinusTwo = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var current = Math.Max(nums[i] + currentMinusTwo, currentMinusOne);

            currentMinusTwo = currentMinusOne;
            currentMinusOne = current;
        }

        return currentMinusOne;
    }
}
