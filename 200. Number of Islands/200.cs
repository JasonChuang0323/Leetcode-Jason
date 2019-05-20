// Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

// Example 1:

// Input:
// 11110
// 11010
// 11000
// 00000

// Output: 1
// Example 2:

// Input:
// 11000
// 11000
// 00100
// 00011

// Output: 3

// 回朔找位置

public class Solution {
    int m;
    int n;
    public int NumIslands(char[][] grid) {
        if(grid.Length == 0)
            return 0;
        m = grid.Length;
        n = grid[0].Length;
        //设立mxn个数组，每个都为false，代表没有访问过
        var isVisited = new bool[m,n];
        int re = 0;
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                if(grid[i][j] == '1' && !isVisited[i, j]){
                    re++;
                    DFS(grid, i, j, isVisited);
                }
        return re;
    }
    
    private void DFS (char[][] grid, int x, int y, bool [,] isVisited ){
        //不超过边界
        if(x >= m|| x < 0 || y >= n || y < 0 ) return;
        // 没访问过
        if(isVisited[x,y]) return;
        // 不是0 是1 就往下继续
        if(grid[x][y] == '0') return;
        // 访问过后要改为true
        isVisited[x,y] = true;
        //上下左右
        var directions =  new (int,int)[]{(0, 1), (0, -1), (1, 0), (-1, 0) };
        
        //每次往一个方向前进
        foreach (var dir in directions){
            int newX = x + dir.Item1;
            int newY = y + dir.Item2;
            DFS(grid, newX, newY, isVisited);
        }         
    }
}