public class Solution {
    public int StrStr(string haystack, string needle) {
        if (needle.Length == 0)
            return 0;
        if(needle.Length > haystack.Length)
            return -1;
        int start = 0;
        
        for(int i = 0; i < haystack.Length; i++){
            if (haystack[i] == needle[start]){
                start++;
                if(start == needle.Length)
                    return i - start + 1;
            }
            else{
                i -= start;
                start = 0;
            }
                
        }
        return -1;
    }
}