public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var result = 0;
        
        while (left < right)
        {
            var width = right - left;
            var height = Math.Min(heights[left], heights[right]);
            var area = width * height;
            result = Math.Max(result, area);

            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return result;
    }
}
