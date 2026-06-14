public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = int.MaxValue;
        for(int i = 0; i < prices.Length; i++) {
            minPrice = Math.Min(prices[i], minPrice);
            int currProfit = prices[i] - minPrice;
            maxProfit = Math.Max(currProfit, maxProfit);
        }
        return maxProfit;
    }
}
