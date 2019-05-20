// Given a 2D board and a word, find if the word exists in the grid.

// The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

// Example:

// board =
// [
//   ['A','B','C','E'],
//   ['S','F','C','S'],
//   ['A','D','E','E']
// ]

// Given word = "ABCCED", return true.
// Given word = "SEE", return true.
// Given word = "ABCB", return false.


//回朔法，每次找到一个单词，找他四个方向，一直下去，如果有相同的就重复这个动作到最后。


public class Solution {
    int n;
    int m;
    public bool Exist(char[][] board, string word) {
        n = board.Length;
        m = board[0].Length;
        
        var isVisited = new bool[n,m];
        var result = false;
        for(int i = 0; i < n; i++)
            for(int j = 0; j < m; j++){
                if(result = Helper(board, word, isVisited, 0, i, j))
                    return true;
            }
        return false;
    }
    
    private bool Helper(char[][]board,string word,  bool[,] isVisited, int index, int x, int y){
        if(index == word.Length)
            return true;
        
        if( x>=n || x<0 || y>=m || y<0)
            return false;
        
        if(word[index] != board[x][y])
            return false;
        
        if(isVisited[x,y]) return false;
        //代表可以访问了，并且目前为止找的字母是正确的。
        isVisited[x,y] = true;
        // 代表4个方向
        var directions = new(int, int)[]{(0, 1), (0, -1), (1, 0), (-1, 0)};
        
        for(int i=0; i < 4; i++){
            int newx = x + directions[i].Item1;
            int newy = y + directions[i].Item2;
            var oneResult = Helper(board,word, isVisited, index + 1, newx, newy);
            if(oneResult) return true;
        }
        isVisited [x,y] = false;
        
        return false;
    }
}