// Given a non-empty array containing only positive integers, find if the array can be partitioned into two subsets such that the sum of elements in both subsets is equal.

// Note:

// Each of the array element will not exceed 100.
// The array size will not exceed 200.
 

// Example 1:

// Input: [1, 5, 11, 5]

// Output: true

// Explanation: The array can be partitioned as [1, 5, 5] and [11].
 

// Example 2:

// Input: [1, 2, 3, 5]

// Output: false

// Explanation: The array cannot be partitioned into equal sum subsets.







public class Solution {
    public bool CanPartition(int[] nums) {
        //背包问题
        int sum = 0;
        
        foreach(int i in nums)
            sum +=i;
        //如果总和不能被2整除，代表找不到2个set，互相相等
        if(sum%2 != 0)
            return false;
        
        int C = sum / 2;
        int n = nums.Length;
        // 先初始化，全部为false；
        var memo = new List <bool>();
        for(int i = 0 ; i < C + 1; i ++)
            memo.Add(false);
        // 先找nums里第一个数可以填满的背包值，就是初始化，一定要放第一个进去。
        
        for(int i = 0; i < memo.Count; i++)
            memo[i] = (i == nums[0]);
        // 在从Nums的2开始找，
        for(int i = 1; i < n; i++)
            // 从要填满的数来往前找，每次2个条件，分别为 不放这个包能不能够，和放了这个包后够不够.
            for(int j = C; j >= nums[i]; j--)
                memo[j] = memo[j] || memo[j - nums[i]];
        // 最后返回在所有过程中，目标值有没有true过
        return memo[C];
    }
}