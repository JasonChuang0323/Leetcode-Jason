



// Given a positive integer n, find the least number of perfect square numbers (for example, 1, 4, 9, 16, ...) which sum to n.

// Example 1:

// Input: n = 12
// Output: 3 
// Explanation: 12 = 4 + 4 + 4.
// Example 2:

// Input: n = 13
// Output: 2
// Explanation: 13 = 4 + 9.




public class Solution {
    public int NumSquares(int n) {

        int [] record = new int [n + 1];
        bool[] visited = new bool [n + 1];
        var q = new Queue<int>();
        
        for(int i=0; i<record.Length; i++){
            record[i] = 0;
            visited[i] = false;
        }
        
        
        visited[n] = true;
        q.Enqueue(n);
        
        while(q.Count > 0){
            
            int num = q.Dequeue();
            
            int step = record[num];
            
            for( int i = 1 ; ; i++){
                int a = num - i*i;
                if( a < 0) {
                    break;
                }
                if(a == 0) {
                    return step + 1;
                }
                if(!visited[a]){
                    q.Enqueue(a);
                    record[a] = step + 1;
                    visited[a] = true;
                }
            }
        }    
        return 1;
    }
    
}

