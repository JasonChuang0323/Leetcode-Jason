
public class Solution {
    //因为会溢出Int, 所以用long.
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t) {
        if (t < 0) return false;
        SortedSet<long> ss = new SortedSet<long>();
        for(int i = 0; i < nums.Length; i++){
        // 判断有序的set里有没有 在 这个范围里的值，如果有 则代表肯定有满足t 的条件。
        if(ss.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0) return true;         
                       
            ss.Add(nums[i]);
            
            if( i >= k) {
                ss.Remove(nums[i - k]);
            }
        }
        return false;    
    }
}