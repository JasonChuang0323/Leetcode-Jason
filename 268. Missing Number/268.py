# Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

# Example 1:

# Input: [3,0,1]
# Output: 2
# Example 2:

# Input: [9,6,4,2,3,5,7,0,1]
# Output: 8


class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        total_sum = 0
        cur_sum = 0
        cur = 0
        
        for i in range(len(nums)):
            total_sum += cur
            cur+=1
            cur_sum += nums[i]
        
        return total_sum + cur - cur_sum