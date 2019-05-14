// Given an unsorted array of integers, find the length of longest increasing subsequence.

// Example:

// Input: [10,9,2,5,3,7,101,18]
// Output: 4 
// Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4. 


//DP, 循环每次只要前面的数字比当前的小，就会有一条序列，一直找到每个数字的序列大小值，
// 最后比较谁的最大




public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums.Length == 0) return 0;
        // 先全部设为1 [1,1,1,1,1,1,1,1...]
        var L = new List <int>();
        for(int i = 0; i < nums.Length; i++)
            L.Add(1);
        
        // 找到当前点，与前面的比较，只要比前面大就在前面的值+1，并且和现在的比较哪个长
        for(int i = 0; i < nums.Length; i++)
            for(int j = 0; j < i; j++)
                if(nums[i] > nums[j])
                    L[i] = Math.Max(L[i], L[j] + 1);
                    
        int re = 0;
        
        for(int i = 0; i < L.Count; i++)
            if(L[i] > re)
                re = L[i];
        
        return re;
    }
}