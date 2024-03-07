public class Solution {
    public int DeleteAndEarn(int[] nums) {
        int[] dp = new int[10001];
        int max = 0;
        for(int i = 0; i < nums.Length;i++)
        {
            dp[nums[i]]++;
            if(max < nums[i])
                max = nums[i];   
        }

        int sum = 0;
        int prev = 0;
        for(int i = 0;i <= max;i++)
        {
            int temp = sum;
            sum = Math.Max(sum, prev + dp[i] * i);
            prev = temp;
        }
        return sum;
    }// cac phan tu lien tiep se k dk chon tuong tu House Robber
}