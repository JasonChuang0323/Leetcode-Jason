public class Solution {
    public int RomanToInt(string s) {
        var d = new Dictionary<char, int>()
        {
            {'I', 1}, 
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int re = 0;
        for(int i = 0; i < s.Length; i++){
            if(i == s.Length - 1){
                re+=d[s[i]];
                return re;
            }
            if(d[s[i]] >= d[s[i+1]]){
                re += d[s[i]];
            }else{
                re -= d[s[i]];
            }
        }
        
        return re;
    }
}