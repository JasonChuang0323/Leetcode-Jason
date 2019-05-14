// 349. Intersection of Two Arrays

// Given two arrays, write a function to compute their intersection.

// Example 1:

// Input: nums1 = [1,2,2,1], nums2 = [2,2]
// Output: [2]
// Example 2:

// Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
// Output: [9,4]
// Note:

// Each element in the result must be unique.
// The result can be in any order.

// 设置2个set，然后在里面互相查找，C#设置set是用的 HashSet.

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
            HashSet<int> s = new HashSet<int>();

            for (int i = 0; i < nums1.Length; i++){
                s.Add(nums1[i]);
            }
        
            HashSet<int> result = new HashSet<int>();   
            
            for (int i = 0; i < nums2.Length; i++){
                if (s.Contains(nums2[i]) ){
                    result.Add(nums2[i]);
                }
            }
        
        return result.ToArray();
            
    }