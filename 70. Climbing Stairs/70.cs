// You are climbing a stair case. It takes n steps to reach to the top.

// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

// Note: Given n will be a positive integer.

// Example 1:

// Input: 2
// Output: 2
// Explanation: There are two ways to climb to the top.
// 1. 1 step + 1 step
// 2. 2 steps
// Example 2:

// Input: 3
// Output: 3
// Explanation: There are three ways to climb to the top.
// 1. 1 step + 1 step + 1 step
// 2. 1 step + 2 steps
// 3. 2 steps + 1 step

public class Solution {
    public int ClimbStairs(int n) {    
        var re = new List <int>();
        
        for(int i = 0; i < n+1; i++)
            re.Add(-1);
        if(n == 1) return 1;
        
        re[1] = 1;
        re[2] = 2;
        
        if(n == 1) return re[1];
        
        for(int i = 3; i <= n; i++)
            re[i] = re[i-1] + re [i-2];
        
        return re[n];

        // Solution2

        // if (n == 0) return 0;
        // if (n == 1) return 1;
        // if (n == 2) return 2;

        // var prePre = 1;
        // var pre = 2;

        // for (int i = 2; i < n; i++) {
        //     var cur = prePre + pre;
        //     prePre = pre;
        //     pre = cur;
        // }

        // return pre;

    }
    
}