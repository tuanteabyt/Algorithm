public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int n=obstacleGrid.Length,m=obstacleGrid[0].Length;
        int[,] dp=new int[n+1,m+1];
        if(obstacleGrid[0][0]==1) return 0;
        for(int i=0;i<n;i++){
            dp[i,0]=obstacleGrid[i][0]==1?0:1;
            if(dp[i,0]==0) i=n;
        }
        for(int i=0;i<m;i++){
            dp[0,i]=obstacleGrid[0][i]==1?0:1;
            if(dp[0,i]==0) i=m;
        }
        for(int i=1;i<n;i++){
            for(int j=1;j<m;j++){
                if(obstacleGrid[i][j]==0)
                dp[i,j] = dp[i,j -1] + dp[i - 1,j];  
            }
        }
        return dp[n-1,m-1];
    }
}