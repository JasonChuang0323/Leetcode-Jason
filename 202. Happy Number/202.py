# Write an algorithm to determine if a number is "happy".

# A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. Those numbers for which this process ends in 1 are happy numbers.

# Example: 

# Input: 19
# Output: true
# Explanation: 
# 12 + 92 = 82
# 82 + 22 = 68
# 62 + 82 = 100
# 12 + 02 + 02 = 1

# 只要是happynumber,那就一定会变为1，如果不是，那就一定会重复之前变过的

class Solution:
    def isHappy(self, n: int) -> bool:
        s = []
        s = set(s)
        temp = 0

        while n != 1:
            for i in str(n):
                temp += int(i)**2
            n = temp
            if (n in s):
                return False
            temp = 0
            s.add(n)
        return True