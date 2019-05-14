// Given a positive integer n, break it into the sum of at least two positive integers and maximize the product of those integers. Return the maximum product you can get.

// Example 1:

// Input: 2
// Output: 1
// Explanation: 2 = 1 + 1, 1 × 1 = 1.
// Example 2:

// Input: 10
// Output: 36
// Explanation: 10 = 3 + 3 + 4, 3 × 3 × 4 = 36.
// Note: You may assume that n is not less than 2 and not larger than 58.、


public class Solution {
    public int IntegerBreak(int n) {
        var memo = new List<int>();
        for(int i = 0; i <= n+1; i++){
            memo.Add(0);
        }
        
        if(n <= 2) return 1;
        memo[1] = 0;
        memo[2] = 1;
        //从最小开始算每个的答案
        for (int i = 3; i<=n; i++){
            //对每个答案 依次-j， 来看有多少种可能，存最大的
            for(int j = 1; j < i; j ++){ // i-1是因为，要把i 分为至少2份
    // 算当前的值，和 分为2份的值 就是 j * i-j 或者是 分为多分的值 那就是 j * memo[i-j]
                 memo[i] = Math.Max(memo[i], Math.Max(j*(i-j) , j*memo[i-j]));
            }
        }
        
        return memo[n];
    }
}