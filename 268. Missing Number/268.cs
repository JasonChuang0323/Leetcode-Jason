public class Solution {
    public int MissingNumber(int[] nums) {
        int total = 0;
        int i;
        
        for(i = 0; i < nums.Length; i++){
            total += i;
            total -= nums[i];
        }
        total += i;
        return total;
    }
}