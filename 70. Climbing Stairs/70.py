class Solution:
    def climbStairs(self, n: int) -> int:
        re = [0 for x in range(n+1)]
        
        
        for i in range(n+1):
            if(i == 1):
                re[1] = 1
            if(i == 2):
                re[2] = 2
            if(i >= 3):
                re[i] = re[i-1] + re[i-2]
        
        return re[n];