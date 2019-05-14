// Given two integers n and k, return all possible combinations of k numbers out of 1 ... n.

// Example:

// Input: n = 4, k = 2
// Output:
// [
//   [2,4],
//   [3,4],
//   [2,3],
//   [1,2],
//   [1,3],
//   [1,4],
// ]


// 回朔法.


public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        if(n < 0 || k > n || k < 0) return null;
        
        var cur = new List<int>();
        var re = new List<IList<int>>();
        int index = 1;
        Helper (n, k, cur, re, index );
        
        return re;
    }
    
    private void Helper (int n, int k, List<int> cur, List<IList<int>> re, int index){
        
        if (cur.Count == k){
            re.Add(new List<int>(cur));
            return;
        }
        
        for (int i = index; i <= n; i++){
            cur.Add(i);
            Helper(n,k,cur,re,i + 1);
            cur.RemoveAt(cur.Count - 1);
        }
    }
}