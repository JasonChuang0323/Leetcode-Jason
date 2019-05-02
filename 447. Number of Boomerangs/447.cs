// Given n points in the plane that are all pairwise distinct, a "boomerang" is a tuple of points (i, j, k) such that the distance between i and j equals the distance between i and k (the order of the tuple matters).

// Find the number of boomerangs. You may assume that n will be at most 500 and coordinates of points are all in the range [-10000, 10000] (inclusive).

// Example:

// Input:
// [[0,0],[1,0],[2,0]]

// Output:
// 2

// Explanation:
// The two boomerangs are [[1,0],[0,0],[2,0]] and [[1,0],[2,0],[0,0]]

// 把距离放字典的key，value放几个，2个以上的都可以记录下来。



public class Solution {
    public int NumberOfBoomerangs(int[][] points) {
        
        int re = 0;
        for(int i = 0; i < points.Length; i++){
            Dictionary <int, int> d = new Dictionary <int, int> ();
            for(int j = 0; j < points.Length; j++){
                if(i != j){
                int dis = (points[i][0] - points[j][0]) *(points[i][0] - points[j][0]) +  (points[i][1] - points[j][1]) * (points[i][1] - points[j][1]) ;
                    
                    
                    if(d.ContainsKey(dis)){
                        d[dis]++;
                    }else{
                        d[dis] = 1;
                    }
                }
                
            }
            //如果是3个，那么会有3*2种可能。因为有2个位置里选3个
        foreach( int item in d.Values){
            re+= item* (item-1);
        }
        }
        

        
        return re;
    }
}