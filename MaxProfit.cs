public class Solution {
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int min = int.MaxValue;
        int max = int.MinValue;

        for(int i = 0; i < prices.Length; i++)
        {
            min = Math.Min(min, prices[i]);
            max = Math.Max(max, prices[i] - min);
        }

        return max;
    }
}