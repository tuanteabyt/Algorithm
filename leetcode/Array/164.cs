public class Solution {
    public int MaximumGap(int[] nums) {
        int n=nums.Length,ans=0;
        if(n==1) return 0;
        Array.Sort(nums);
        for(int i=1;i<n;i++){
            ans=Math.Max(ans,nums[i]-nums[i-1]);
        }
        return ans;
    }
}