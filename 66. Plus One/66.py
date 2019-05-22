# Given a non-empty array of digits representing a non-negative integer, plus one to the integer.

# The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.

# You may assume the integer does not contain any leading zero, except the number 0 itself.

# Example 1:

# Input: [1,2,3]
# Output: [1,2,4]
# Explanation: The array represents the integer 123.
# Example 2:

# Input: [4,3,2,1]
# Output: [4,3,2,2]
# Explanation: The array represents the integer 4321.

#先拿出所有数组，+1
#然后接回去
#从list的head加入 用的 insert（item,位置）

#append是从尾巴进入







class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        re = 0
        for i in digits:
            re = re*10 + i;
        re +=1
        result = []
        while re > 0:
            tmp = re%10
            re = re//10
            result.insert(0, tmp)
        return result