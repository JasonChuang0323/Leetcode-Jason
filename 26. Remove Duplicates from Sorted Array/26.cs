public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 0){
            return 0;
        }
        int left = 0;
        for (int i =0; i < nums.Length; i++){
            if (nums[i] != nums[left]){
                nums[++left] = nums[i];
            }
        }
        return left + 1;
    }
}