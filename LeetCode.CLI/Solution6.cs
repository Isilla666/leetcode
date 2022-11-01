//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
public class Solution6 
{
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var min2 = prices[0];
        var max = prices[0];
        var sum = 0;
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min2)
            {
                min2 = prices[i];
            }
            if (prices[i] > max)
            {
                max = prices[i];
            }
            if (sum < prices[i] - min)
            {
                sum = prices[i] - min;
            }
            if (prices[i] - min2 > sum)
            {
                min = min2;
                sum = prices[i] - min;
                max = prices[i];
            }
        }
        return max - min;
    }
}