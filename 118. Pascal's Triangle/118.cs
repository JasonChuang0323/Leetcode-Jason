public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var re = new List<IList<int>>();
        
        for(int i = 0; i < numRows; i++){
            var tmp = new List<int>();
            tmp.Add(1);
            for(int j = 1; j < i; j++ ){
                tmp.Add(re[i-1][j-1] + re[i-1][j]);
            }
            if(i > 0)
                tmp.Add(1);
            re.Add(tmp);
        }
        
        return re;
    }
}