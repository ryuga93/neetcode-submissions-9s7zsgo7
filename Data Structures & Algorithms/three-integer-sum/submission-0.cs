public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        for (var i = 0; i < nums.Length - 1; i++)
        {
            var a = nums[i];
            if (a > 0)
            {
                break;
            }

            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] + nums[i] > 0)
                {
                    right--;
                    continue;
                }

                if (nums[left] + nums[right] + nums[i] < 0)
                {
                    left++;
                    continue;
                }

                
                result.Add(new List<int> { nums[i], nums[left], nums[right] });
                left++;
                right--;
                while (left < right && nums[left] == nums[left - 1])
                {
                    left++;
                }
            }
        }

        return result;
    }
}
