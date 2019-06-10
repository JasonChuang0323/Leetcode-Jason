public class Solution {
    public void Rotate(int[] nums, int k) {
        
        var tmp = new int[nums.Length];
        int l = nums.Length;
        k %= l;
        Array.Copy(nums, l-k, tmp, 0, k );
        Array.Copy(nums, 0, nums, k, l-k);
        Array.Copy(tmp, 0, nums, 0, k);

    }
}