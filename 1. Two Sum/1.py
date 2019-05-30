class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        a = {}
        for i in range(len(nums)):
            tmp = target - nums[i]
            if(tmp in a):
                return [a[tmp], i ]
            else:
                a[nums[i]] = i
        