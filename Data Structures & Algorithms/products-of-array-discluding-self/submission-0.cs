public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var resultPrefix = new int[nums.Length];
            var resultSuffix = new int[nums.Length];
            
            var result = new int[nums.Length];
            
            resultPrefix[0] = 1;
            resultSuffix[nums.Length - 1] = 1;
            
            for (var i = 1; i < nums.Length; i++)
            {
                resultPrefix[i] = nums[i - 1] * resultPrefix[i - 1];
            }

            for (var i = nums.Length - 2; i >= 0; i--)
            {
                resultSuffix[i] = nums[i + 1] * resultSuffix[i + 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = resultPrefix[i] * resultSuffix[i];
            }
            
            return result;
    }
}
