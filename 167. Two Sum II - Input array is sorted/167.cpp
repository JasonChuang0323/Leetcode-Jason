//双指针,左右前进



class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        int left = 0;
        int right = numbers.size() - 1;
        while (left < right){
            if (numbers[left] + numbers[right] == target){
                int res[2] = {left+1, right+1};
                return vector <int>(res, res + 2);
            }else if (numbers[left] + numbers[right] < target)
                left++;
            else
                right--;
        }  
    return vector<int>();
    }
};