public class Solution {
    public int MinPathSum(int[][] grid) {
        int m=grid.Length;
        int n=grid[0].Length;
       int [,] dp= new int [m,n];
        for(int i=0;i<m;i++){
       for(int j=0;j<n;j++)
       {
           dp[i,j]= int.MaxValue;
       }}
       dp[0,0]=grid[0][0];
        for(int j=1;j<m;j++)
       {
           dp[j,0]=Math.Min(dp[j,0],dp[j-1,0]+grid[j][0]);
       }
    //         for(int j=1;j<m;j++)
    //    {
    //        dp[j][n-1]=min(dp[j][n-1],dp[j-1][n-1]+gird[j][n-1]);
    //    }
            for(int j=1;j<n;j++)
       {
           dp[0,j]=Math.Min(dp[0,j],(dp[0,j-1]+grid[0][j]));
       }
    //          for(int j=1;j<n;j++)
    //    {
    //        dp[0][j]=min(dp[0][j],dp[0][j-1]+gird[0][j]);
    //    }
       for(int i=1;i<m;i++){
       for(int j=1;j<n;j++)
       {   int a=Math.Min((dp[(i-1),j]+grid[i][j]),(dp[i,j-1]+grid[i][j]));
           dp[i,j]=Math.Min(dp[i,j],a);
       }

       }
       return dp[m-1,n-1];
    }
    }
