public class Solution {
    public int CountPrimes(int n) {
        if(n < 3) return 0;
        var L = new bool[n];
        L[0] = true;
        L[1] = true;
        int re = 0;
        
        for(int i = 2; i < n; i++)
            if(!L[i]){
                re+=1;
                for(int j = 1; j < n; j++){
                    if(i*j >= n) break;
                    L[i*j] = true;
                }
            }
        return re;
    }
}