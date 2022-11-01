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
    public int MaxProfit2(int[] prices) {
        
        int l=0, r=1; 
        int profit, maxProfit = 0;

        while(r < prices.Length)
        {
        
            if(prices[l] > prices[r])
            {
                l=r;
                r++;
            }
            else
            { 
                profit = prices[r] - prices[l];

                if(maxProfit < profit)
                {
                    maxProfit = profit;
                }
                r++;
            }
        }
        return maxProfit;
    }
    public int MaxProfit3(int[] prices) {
        int maxProfit = 0, maxCurr = 0;
        for(int i=1;i<prices.Length;i++) {
            maxCurr += prices[i] - prices[i-1];
            maxProfit = Math.Max(maxProfit, maxCurr);
            maxCurr = maxCurr > 0 ? maxCurr : 0;
        }
        return maxProfit;
    }
}