// Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.

// Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

// Note: You are not suppose to use the library's sort function for this problem.

// Example:

// Input: [2,0,2,1,1,0]
// Output: [0,0,1,1,2,2]


class Solution {
public:
    // time O(n)
    // space O(1)
    // 三路快排
    void sortColors(vector<int>& nums) {
        
        int zero = -1;
        int two = nums.size();
        
        for(int i = 0; i < two; ){
            if (nums[i] == 1)
                i++;
            else if (nums[i] == 2){
                two--;
                swap(nums[i], nums[two]);
            }
            //如果是0
            else{
                zero++;
                swap(nums[zero], nums[i]);
                i++;
            }
                
        }
        
    }
};