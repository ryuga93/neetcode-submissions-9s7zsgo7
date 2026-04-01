public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
            var freq = new List<int>[nums.Length + 1];
            for (int i = 0; i <= nums.Length; i++)
            {
                freq[i] = new List<int>();
            }
            foreach (var num in nums)
            {
                if (!dict.TryAdd(num, 1))
                {
                    dict[num]++;
                }
            }

            foreach (var pair in dict)
            {
                freq[pair.Value].Add(pair.Key); 
            }

            var result = new int[k];
            var index = 0;
            for (var i = freq.Length - 1; i > 0 && index < k; i--)
            {
                foreach (var num in freq[i])
                {
                    result[index] = num;
                    index++;
                }
            }

            return result;
    }
}
