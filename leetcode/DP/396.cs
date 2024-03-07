public class Solution {
    public int MaxRotateFunction(int[] nums) {
        int n=nums.Length;
        int[] dp=new int[n];
        int sum=0,max;
        for(int i=0;i<n;i++){
           sum+=nums[i];
           dp[0]+=nums[i]*i;
        }
        max=dp[0];
         for(int i=1;i<n;i++){
           dp[i]=dp[i-1]+sum-n*nums[n-i];
           max=Math.Max(dp[i],max);
        }
        return max;
    }
}
// F(k) = [k, k+1...n-2,n-1,0,....k-1] * A[n]
// F(k+1) = [k+1,k+2...n-1,0, 1,.....k] * A[n]
// so
// F(k+1) - F(k) = [1,1,1...-n+1,1,1,1] * A[n] = sum(A[n]) - n * A[n - 1 - k];