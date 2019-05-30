public class Solution {
    public bool IsHappy(int n) {
        var s = new HashSet<int>();
        int tmp = 0;
        while (n != 1){
            foreach(var i in n.ToString())
                tmp += (i - '0')*(i - '0');
            n = tmp;
            if(s.Contains(n)){
                return false;
            } 
            tmp = 0;
            s.Add(n);
        }
        return true;
    }
}