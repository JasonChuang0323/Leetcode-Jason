// Example 1:

// Input: nums1 = [1,2,2,1], nums2 = [2,2]
// Output: [2,2]
// Example 2:

// Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
// Output: [4,9]


// 设置一个字典，存nums1每个的字数，在设置一个List，只要在字典里能找到nums2的key，并且判断是否还存在
// ，如果有就存在list里，记住要判断一下是否存爱这个key值



public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary <int,int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums1.Length; i++){
            if(!d.ContainsKey(nums1[i])){
                d[nums1[i]] = 1;
            }else{
                d[nums1[i]]++;               
            }

        }
        
        List<int> l = new List<int>();
        
        for(int i = 0; i < nums2.Length; i++){
            if(d.ContainsKey(nums2[i])){
                if(d[nums2[i]] > 0){
                l.Add(nums2[i]);
                d[nums2[i]]--;
            }
            }

        }
        
        return l.ToArray();
    }
}