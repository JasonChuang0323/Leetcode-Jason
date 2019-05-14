// Given a collection of distinct integers, return all possible permutations.

// Example:

// Input: [1,2,3]
// Output:
// [
//   [1,2,3],
//   [1,3,2],
//   [2,1,3],
//   [2,3,1],
//   [3,1,2],
//   [3,2,1]
// ]

// 回朔法，

public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        if (nums.Length == 0) return null;
        var table = new bool[nums.Length];
        
        var re = new List<IList<int>>();
        Helper(nums, new List<int>(), table, re);
        
        return re;
    }
    
    private void Helper (int[] nums, List<int> cur, bool[] table, IList<IList<int>> re) {
        
        if(cur.Count == nums.Length){
            re.Add(new List<int>(cur));
            return;
        }
        
        for(int i = 0; i < nums.Length; i++){
            if(table[i]) continue;
            cur.Add(nums[i]);
            table[i] = true;
            Helper(nums, cur, table, re);
            cur.RemoveAt(cur.Count - 1);
            table[i] = false;
        }
    }
}