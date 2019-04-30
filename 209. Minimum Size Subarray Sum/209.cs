// Given an array of n positive integers and a positive integer s, find the minimal length of a contiguous subarray of which the sum ≥ s. If there isn't one, return 0 instead.

// Example: 

// Input: s = 7, nums = [2,3,1,2,4,3]
// Output: 2
// Explanation: the subarray [4,3] has the minimal length under the problem constraint.


// Runtime: 96 ms, faster than 100.00% of C# online submissions for Minimum Size Subarray Sum.
// Memory Usage: 23.5 MB, less than 27.27% of C# online submissions for Minimum Size Subarray Sum.

//思想就是创建一个移动窗口，如果不够大则右边+1， 如果太大则左边+1，每次记录最小的长度。




public class Solution {
    public int MinSubArrayLen(int s, int[] nums) {
        int l = 0 , r = -1;
        int sum = 0;
        int rest = nums.Length + 1;
        
        while(l < nums.Length){
            //注意不要让r超过了边界

            if(r+1 < nums.Length && sum < s){
                r++;
                sum+=nums[r];
            }else{
                sum-=nums[l];
                l++;
            }
            
            if(sum >= s){
                rest = Math.Min(rest, r-l+1);
            }
        }
        
        if(rest == nums.Length + 1){
            return 0;
        }
        return rest;
    }
}