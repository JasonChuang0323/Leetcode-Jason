class Solution:
    def singleNumber(self, nums: List[int]) -> int:
        d = {}
        for i in nums:
            if i not in d:
                d[i] = 1
            else:
                d[i] += 1
        for i in d:
            if(d[i] == 1):
                return i

# // solution 2

# using XOR

# because a^a^b = b

# class Solution:
#     def singleNumber(self, nums: List[int]) -> int:
#         re = 0;
#         for x in nums:
#             re = re ^ x
        
#         return re