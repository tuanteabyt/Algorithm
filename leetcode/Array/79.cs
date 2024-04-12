public class Solution {
    public bool Exist(char[][] board, string word) {
         for (int i = 0; i < board.Length; ++i) {
            for (int j = 0; j < board[0].Length; ++j) {
                string a="";
                if (isSafe(board,i,j,word,a)) {
                    return true;
                }
            }
        }
        return false;
    }
     bool isSafe(char [][] board, int row, int col,string word,string a)
    {
        int i, j;
        if(row>=board.Length||col>=board[0].Length||col<0||row<0||board[row][col]!=word[a.Length]) return false;
        a=a+board[row][col];
        if(a.Equals(word)) return true; 
        char temp = board[row][col];
        board[row][col] = '\0';
        bool result= isSafe(board,row,col+1,word,a)||isSafe(board,row-1,col,word,a)||(isSafe(board,row+1,col,word,a)||isSafe(board,row,col-1,word,a));
        board[row][col] = temp; 
        return result;
    }
}