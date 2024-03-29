public class Solution {
    public int Change(int amount, int[] coins) {
        int n=coins.Length;
        int[] dp=new int[amount+1];
        dp[0]=1;
        for(int i=0;i<n;i++){
            for(int j=1;j<=amount;j++)
            if(j>=coins[i])
            dp[j]=dp[j-coins[i]]+dp[j];
        }
        return dp[amount];
    }
}