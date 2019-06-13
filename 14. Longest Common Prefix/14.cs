public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0)
            return "";
        
        int endPoint = 0;
        
        for(int i = 0; i < strs[0].Length; i++){
            foreach ( var word in strs){
                if( i >= word.Length || strs[0][i] != word[i]){
                    return strs[0].Substring(0, i);
                }
            }
        }
        
        return strs[0];
    }
}