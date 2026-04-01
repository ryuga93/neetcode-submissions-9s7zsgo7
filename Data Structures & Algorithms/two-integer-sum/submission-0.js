class Solution {
    /**
     * @param {number[]} nums
     * @param {number} target
     * @return {number[]}
     */
    twoSum(nums, target) {
        const dict = {};
        for (let i = 0; i < nums.length; i++)
        {
            let j = dict[(target - nums[i])];
            if (j !== undefined)
            {
                return [i, j]
            }

            dict[nums[i]] = i;
        }
    }
}
