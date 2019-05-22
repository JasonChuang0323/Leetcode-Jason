
//背包问题，DP来做。找当前可以找到的最大值。

public class Solution {
    public int MaxSubArray(int[] nums) {
        var l = new List <int>();
        for(int i = 0; i < nums.Length; i++)
            l.Add(-1);
        
        l[0] = nums[0];
        for(int i = 1; i < nums.Length; i++){
            l[i] = Math.Max(nums[i] + l[i - 1], nums[i]);
        }
        int max = Int32.MinValue;
        foreach(var i in l)
            if(i > max)
                max = i;
        return max;
    }
}