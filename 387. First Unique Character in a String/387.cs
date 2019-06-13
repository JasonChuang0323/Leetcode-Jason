public class Solution {
    public int FirstUniqChar(string s) {
        var d = new Dictionary<char, int>();
        
        foreach(var i in s){
            if(d.ContainsKey(i))
                d[i]++;
            else
                d.Add(i,1);
        }
        
        foreach(KeyValuePair <char,int> kvp in d){
            if(kvp.Value == 1)
                return s.IndexOf(kvp.Key);
        }
        
        return -1;
    }
}


solution 2

public int FirstUniqChar(string s) {
        
        for(int i=0;i<s.Length;i++)                 
            if(s.IndexOf(s[i]) == s.LastIndexOf(s[i]))
                return i;
        return -1;
    }