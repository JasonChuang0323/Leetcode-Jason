// Given four lists A, B, C, D of integer values, compute how many tuples (i, j, k, l) there are such that A[i] + B[j] + C[k] + D[l] is zero.

// To make problem a bit easier, all A, B, C, D have same length of N where 0 ≤ N ≤ 500. All integers are in the range of -228 to 228 - 1 and the result is guaranteed to be at most 231 - 1.

// Example:

// Input:
// A = [ 1, 2]
// B = [-2,-1]
// C = [-1, 2]
// D = [ 0, 2]

// Output:
// 2

// Explanation:
// The two tuples are:
// 1. (0, 0, 0, 1) -> A[0] + B[0] + C[0] + D[1] = 1 + (-2) + (-1) + 2 = 0
// 2. (1, 1, 0, 0) -> A[1] + B[1] + C[0] + D[0] = 2 + (-1) + (-1) + 0 = 0

//O(n^2)

// 先找A+B 放到字典中，然后查找-(C + D） 有没有在字典中


public class Solution {
    public int FourSumCount(int[] A, int[] B, int[] C, int[] D) {
        
        Dictionary <int, int> d = new Dictionary<int,int>();
        int re = 0;
        for(int i = 0; i < A.Length; i++){
            for(int j = 0; j < B.Length; j++){
                if(d.ContainsKey(A[i] + B[j])){
                    d[A[i] + B[j]]++;
                }else{
                    d[A[i] + B[]] = 1;
                }
            }
        }
        
        for(int i = 0; i < C.Length; i++){
            for(int j = 0; j < D.Length; j++){
                if(d.ContainsKey(-(C[i] + D[j]))){
                    re += d[-(C[i] + D[j])];
                }
            }
        }
        
        return re;
    }
}

