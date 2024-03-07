public class Solution {
    public int MaxCoins(int[] nums) {
        int n = nums.Length;
        int[] paddedNums = new int[n + 2];
        paddedNums[0] = paddedNums[n + 1] = 1; 
        Array.Copy(nums, 0, paddedNums, 1, n);
        
        int[,] dp = new int[n + 2, n + 2];
        for (int len = 1; len <= n; len++) {
            for (int i = 1; i <= n - len + 1; i++) {
                int j = i + len - 1;
                for (int k = i; k <= j; k++) {
                    dp[i, j] = Math.Max(dp[i, j], dp[i, k - 1] + dp[k + 1, j] + paddedNums[i - 1] * paddedNums[k] * paddedNums[j + 1]);
                }
            }
        }
        return dp[1, n];
    }//xet bong K no sau cung
}