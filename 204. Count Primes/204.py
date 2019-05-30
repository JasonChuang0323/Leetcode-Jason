//不够优化 会超时。

# class Solution:
#     def countPrimes(self, n: int) -> int:
#         re = 0
#         x = 0
#         if n < 3: return 0 
#         for i in range(2,n):
#             flag = 0
#             if(i == 2): 
#                 re+=1
#                 continue
#             for j in range(2,int(i**0.5)+1):
#                 if(i%j == 0 and i != j):
#                     flag = 1
#                     break
#             if(flag == 0):
#                 re+=1
#         return re

//思路就是，如果这个是2质数，那么2x2,2x3,2x4....2x? > n 都不会是质数，所以可以提前去掉，在算3...
// 以此类推

class Solution:
    def countPrimes(self, n: int) -> int:
        if(n < 2): return 0
        L = [False]*n
        
        L[0] = True
        L[1] = True
        re = 0
        for i in range(2, n):
            if(L[i]): 
                continue
            else:
                re+=1
                for j in range(1,n):
                    if(i*j >= n): 
                        break
                    else:
                        L[i*j] = True
        return re;