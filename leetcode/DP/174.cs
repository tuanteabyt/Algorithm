public class Solution {
    public int CalculateMinimumHP(int[][] dungeon) {
        int n= dungeon.Length;
        int m= dungeon[0].Length;
        if(n==1&m==1) return dungeon[0][0]<0?1-dungeon[0][0]:1;
        int [,] dp=new int[n,m];
        dp[n-1,m-1]=dungeon[n-1][m-1]>0?0:-dungeon[n-1][m-1];
        if(n>1){
        for(int i=n-2;i>=0;i--){
            dp[i,m-1]=dp[i+1,m-1]-dungeon[i][m-1]>0?dp[i+1,m-1]-dungeon[i][m-1]:0;
            }
        }
        if(m>1){
        for(int i=m-2;i>=0;i--){
            dp[n-1,i]=dp[n-1,i+1]-dungeon[n-1][i]>0?dp[n-1,i+1]-dungeon[n-1][i]:0;
            }
        }
        if(n>1&&m>1){
        for(int i=n-2;i>=0;i--){
            for(int j=m-2;j>=0;j--){
                dp[i,j]=Math.Min(dp[i+1,j],dp[i,j+1])-dungeon[i][j];
                if(dp[i,j]<0) dp[i,j]=0;
            }
        }
        }
        return dp[0,0]+1;
    }
}
