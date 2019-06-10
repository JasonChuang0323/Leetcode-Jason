public class Solution {
    public bool IsAnagram(string s, string t) {
        var d = new Dictionary <char,int> ();
        foreach(char i in s){
            if(d.ContainsKey(i))
                d[i]++;
            else
                d.Add(i, 1);
        }
        
        foreach(char i in t){
            if(!(d.ContainsKey(i)))
                return false;
            else
                d[i]--;
        }
        
        foreach(KeyValuePair<char,int> kvp in d){
            if (kvp.Value != 0)
                return false;
        }
        
        return true;
        
        
    }
}