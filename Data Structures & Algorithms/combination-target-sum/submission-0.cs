public class Solution {
    private List<List<int>> result = new List<List<int>>();

    public List<List<int>> CombinationSum(int[] nums, int target) {
        var currentList = new List<int>();
        Backtrack(0, currentList, 0, nums, target);

        return result;
    }

    private void Backtrack(int i, List<int> currentList, int sum, int[] nums, int target)
    {
        if (sum == target)
        {
            result.Add(currentList.ToList());
            return;
        }

        if (i >= nums.Length || sum > target)
        {
            return;
        }

        currentList.Add(nums[i]);
        var includedSum = sum + nums[i];
        Backtrack(i, currentList, includedSum, nums, target);

        currentList.Remove(currentList.Last());
        Backtrack(i + 1, currentList, sum, nums, target);
    }
}
