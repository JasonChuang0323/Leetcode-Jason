class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        d = {}
        for i in nums:
            if (i in d):
                d[i]+=1
            else:
                d[i] = 1
        maxnum = 0
        
        for k, v in d.items():
            if (v > maxnum):
                maxnum = v
                re = k
        return re


solution 2

class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        nums.sort()
        re = len(nums)/2
        return nums[int(re)]