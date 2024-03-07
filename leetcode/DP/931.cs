public class Solution {
    public int MinFallingPathSum(int[][] matrix) {
        int n=matrix.Length;
        int min=int.MaxValue;
        int[,] dp=new int[n+1,n+1];
        for(int i=0;i<=n;i++){
            dp[0,i]=0;
            dp[i,0]=min;
        }
         for(int i=1;i<=n;i++){
             for(int j=1;j<=n;j++){
                if(j<n){
              dp[i,j]=matrix[i-1][j-1]+Math.Min(Math.Min(dp[i-1,j],dp[i-1,j+1]),dp[i-1,j-1]);}
              else
               dp[i,j]=matrix[i-1][j-1]+Math.Min(dp[i-1,j],dp[i-1,j-1]);
             }
        }
         for(int i=1;i<=n;i++){
            min=Math.Min(min,dp[n,i]);
        }
        return min;
    }
}