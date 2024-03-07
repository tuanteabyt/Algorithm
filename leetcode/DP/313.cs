public class Solution {
    public int NthSuperUglyNumber(int n, int[] primes) {
       long[] dp=new long[n];
       int m=primes.Length;
       int[] k=new int[m];
        dp[0]=1;
        for (int i=1; i<n; i++){
            long min = long.MaxValue;
            for (int j=0; j<m; j++) {
                if (min>dp[k[j]]*primes[j]) {
                    min = dp[k[j]]*primes[j];
                }
            }
            dp[i] = min;
            for (int j=0; j<m; j++){
                if (min == dp[k[j]]*primes[j]) k[j]++;
            }
        }
        return (int) dp[n-1];    

    }
}