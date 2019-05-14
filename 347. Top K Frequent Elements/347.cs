// Given a non-empty array of integers, return the k most frequent elements.

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2
// Output: [1,2]
// Example 2:

// Input: nums = [1], k = 1
// Output: [1]


//解法1

    public IList<int> TopKFrequent(int[] nums, int k) {
        Dictionary <int, int> dic = new Dictionary <int, int>();
        
        for(int i = 0; i < nums.Length; i++){
            if (!dic.ContainsKey(nums[i])){
                dic.Add(nums[i], 1);
            }else{
                dic[nums[i]] +=1;
            }
        }
        
        var re = new List<int>();

        while(re.Count < k){
            int max = 0;
            int count = 0; 
            foreach (KeyValuePair <int, int> i in dic){
                if (i.Value > count){
                    max = i.Key;
                    count = i.Value;
                }
            }
            Console.WriteLine(max);
            re.Add(max);
            dic.Remove(max);
        }
        return re;
    }

}

//解法2
// 2 foreach 解决

public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        var dic = new Dictionary <int, int>();
        
        foreach (var n in nums){
            if(dic.ContainsKey(n)) dic[n]+=1;
            else dic.Add(n, 1);
        }
        
        var l = new List <int>();
        foreach (var kvp in dic.OrderByDescending(e => e.Value)){
            Console.WriteLine(l.Count);
            if(l.Count  == k ) break;
            else l.Add(kvp.Key);
            
        }
        
        return l;

    }

}










