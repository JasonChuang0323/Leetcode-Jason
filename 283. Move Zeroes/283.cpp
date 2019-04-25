
// class Solution {
// public:
//     void moveZeroes(vector<int>& nums) {
//         int k = 0;
//         for (int i = 0; i < nums.size(); i++)
//             if (nums[i]){
//                 nums[k] = nums[i];
//                 k++;
//                 }
                
//         for(int j = k; j < nums.size(); j++)
//             nums[j] = 0;
//     }
// };


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