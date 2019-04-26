class Solution {
public:
    void moveZeroes(vector<int>& nums) {
        int k = 0;
        int tmp;
        for (int i = 0; i < nums.size(); i++)
            if (nums[i]){
                tmp = nums[k];
                nums[k] = nums[i];
                nums[i] = tmp;
                k++;
                }
                
    }
};