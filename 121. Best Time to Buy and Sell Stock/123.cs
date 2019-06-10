public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length == 0) return 0;
        int min_num = prices[0];
        int profit = 0;
        foreach(var p in prices){
            min_num = Math.Min(min_num, p);
            int tmp = p - min_num;
            profit = Math.Max(profit, tmp);
        }
        return profit;
    }
}