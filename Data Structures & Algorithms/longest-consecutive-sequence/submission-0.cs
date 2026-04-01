public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
            
        var hashset = new HashSet<int>(nums);
        
        var heads = new List<int>();
        var longest = 0;
        foreach (var num in nums)
        {
            if (hashset.Contains(num - 1))
            {
                continue;
            }
            heads.Add(num);
        }

        var longList = new List<int>(heads.Count);
        foreach (var head in heads)
        {
            longest = 0;
            var next = head;
            while (hashset.Contains(next))
            {
                next += 1;
                longest++;
            }
            longList.Add(longest);
        }

        return longList.Max();
    }
}
