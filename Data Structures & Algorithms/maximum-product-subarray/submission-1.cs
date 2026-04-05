public class Solution {
    public int MaxProduct(int[] nums)
    {
        var result = nums[0];
        var currentMax = 1;
        var currentMin = 1;

        foreach (var num in nums)
        {
            var temp = num * currentMax;
            currentMax = Math.Max(Math.Max(num * currentMax, num * currentMin), num);
            currentMin = Math.Min(Math.Min(temp, num * currentMin), num);

            result = Math.Max(result, currentMax);
        }

        return result;
    }
}
