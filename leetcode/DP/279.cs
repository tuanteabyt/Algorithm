public class Solution {
    public int NumSquares(int n) {
        int[] dp=new int [n+1];
        dp[0]=0;
        dp[1]=1;
        for(int i=2;i<=n;i++){
            dp[i]=int.MaxValue;
            for(int j=1;i-j*j>=0;j++){
                dp[i]=Math.Min(dp[i],dp[i-j*j]+1);
            }
        }
        return dp[n];
    }
}