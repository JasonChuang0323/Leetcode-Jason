
// Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array such that nums[i] = nums[j] and the absolute difference between i and j is at most k.

// Example 1:

// Input: nums = [1,2,3,1], k = 3
// Output: true
// Example 2:

// Input: nums = [1,0,1,1], k = 1
// Output: true
// Example 3:

// Input: nums = [1,2,3,1,2,3], k = 2
// Output: false

//滑动一个K的窗口，每次在SET里查看是否有相同.




public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet <int> h = new HashSet<int>();
        
        for(int i = 0 ; i < nums.Length; i++){
            if (h.Contains(nums[i]))
                return true;
            h.Add(nums[i]);
            
            // 每次保证长度为K
            if(i >= k){
                h.Remove(nums[i-k]);
            }
        }
        return false;
    }
}
