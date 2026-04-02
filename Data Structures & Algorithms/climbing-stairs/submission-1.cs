public class Solution {
    public int ClimbStairs(int n) {     
        var nMinus1 = 1;
        var nMinus2 = 1;

        for (var i = 0; i < n - 1; i++)
        {
            var temp = nMinus1;
            nMinus1 = nMinus1 + nMinus2;
            nMinus2 = temp;
        }

        return nMinus1;
    }
}
