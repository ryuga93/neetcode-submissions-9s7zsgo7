public class Solution {
    public int MaxProfit(int[] prices) {
        var result = 0;
        var buyPrice = prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] > prices[i])
            {
                continue;
            }

            buyPrice = Math.Min(buyPrice, prices[i - 1]);
            if (result > prices[i] - buyPrice)
            {
                continue;
            }

            result = prices[i] - buyPrice;
        }

        return result;
    }
}
