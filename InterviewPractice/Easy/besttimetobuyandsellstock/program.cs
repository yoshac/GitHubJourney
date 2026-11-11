public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxprofit = 0;
        int profit = 0;
        int minprice = prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            // 1. Check whether prices[i] is a new minimum.
            if (prices[i] < minprice)
            {
                minprice = prices[i];
            }

            // 2. Calculate the profit from selling today.
            profit = prices[i] - minprice;
            if (maxprofit == 0 || profit > maxprofit)
            { maxprofit = profit; }

            // 3. Update maxProfit if necessary.
        }

        return maxprofit;
    }
}