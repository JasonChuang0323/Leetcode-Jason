// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice.

// Example:

// Given nums = [2, 7, 11, 15], target = 9,

// Because nums[0] + nums[1] = 2 + 7 = 9,
// return [0, 1].

//O(n)
//O(n)

//用字典然后每次排查，不能一次性全部放进去，因为可能会有相同的value,导致index错误.


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int, int> d = new Dictionary <int, int>();
        int [] re = new int[2];
        for(int i =0; i < nums.Length; i++){
            int temp = target - nums[i];
            if(d.ContainsKey(temp)){
                re[0] = i;
                re[1] = d[temp];
                return re;
            }
            d[nums[i]] = i;
        }
        return re;
    }
}