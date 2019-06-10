public class Solution {
    public int MajorityElement(int[] nums) {
        var d = new Dictionary<int, int>();
        
        foreach (var i in nums){
            if (d.ContainsKey(i))
                d[i]++;
            else{
                d.Add(i, 1);
            }
        }
        
        foreach(KeyValuePair<int,int> kvp in d){
            if (kvp.Value > nums.Length/2)
                return kvp.Key;
        }
        
        return -1;
    }
}