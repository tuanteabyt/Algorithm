public class Solution {
    public long CountSubarrays(int[] nums, int k) {
        long max=nums.Max(),left=0,right=0,n=nums.Length,count=0,ans=0;
        while(right<n){
            if(nums[right]==max){
                count++;
            }
            while(count>=k) {
                if(nums[left]==max)
                count--;
                left++;
            }
            ans+=left;//bớt các kí tự phía trước
            right++;
        }
        return ans;

    }
}