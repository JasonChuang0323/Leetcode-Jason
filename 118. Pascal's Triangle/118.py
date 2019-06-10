# Input: 5
# Output:
# [
#      [1],
#     [1,1],
#    [1,2,1],
#   [1,3,3,1],
#  [1,4,6,4,1]
# ]

class Solution:
    def generate(self, numRows: int) -> List[List[int]]:
        re = []
        for i in range(numRows):
            tmp = [0]*(i+1)
            for j in range(i+1):
                if(j == 0):
                    tmp[0] = 1
                elif(j == i):
                    tmp[j] = 1
                else:
                    print(j)
                    tmp[j] = re[i-1][j-1] + re[i-1][j]
            re.append(tmp)
        return re
        
                