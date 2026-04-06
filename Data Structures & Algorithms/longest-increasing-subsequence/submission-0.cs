public class Solution {
    public int LengthOfLIS(int[] nums)
    {
        List<int> currentSubsequence = new List<int>();
        currentSubsequence.Add(nums[0]);

        for (var i = 1; i < nums.Length; i++)
        {
            if (currentSubsequence[currentSubsequence.Count - 1] < nums[i])
            {
                currentSubsequence.Add(nums[i]);
                continue;
            }

            var index = currentSubsequence.BinarySearch(nums[i]);
            if (index < 0)
            {
                index = ~index;
            }

            currentSubsequence[index] = nums[i];
        }

        return currentSubsequence.Count;
    }
}
