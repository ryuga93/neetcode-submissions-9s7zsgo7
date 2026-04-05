public class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        int[] noOfWays = new int [amount + 1];
        Array.Fill(noOfWays, amount + 1);
        noOfWays[0] = 0;

        for (var i = 0; i < noOfWays.Length; i++)
        {
            foreach (var coin in coins)
            {
                if (coin <= i)
                {
                    noOfWays[i] = Math.Min(noOfWays[i], noOfWays[i - coin] + 1);
                }
            }
        }

        return noOfWays[amount] > amount ? -1 : noOfWays[amount];
    }
}
