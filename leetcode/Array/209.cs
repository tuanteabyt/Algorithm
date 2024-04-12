public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int left=0,right=0,n=nums.Length,sum=0,ans=int.MaxValue;
        while(right<n){
            sum+=nums[right++];
            //  if(sum>=target){
            //     ans=Math.Min(ans,right-left);
            // }
            while(sum>=target){
                sum-=nums[left++];
                ans=Math.Min(ans,right-left+1);
            }
           
        }
        return ans==int.MaxValue?0:ans;
    }
}