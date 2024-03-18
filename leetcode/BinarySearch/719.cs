public class Solution {
    public int SmallestDistancePair(int[] nums, int k) {
        Array.Sort(nums);
        int n = nums.Length;
        int left=0;
        int right=nums[n-1]-0;
        for(int cnt =0;left<right;cnt=0){
            int mid =left+(right-left)/2;
            for(int i=0,j=0;i<n;i++){
                while(j<n && nums[i]+mid>=nums[j]) j++;
                cnt+=j-i-1; 
            }
            if(cnt<k) left=mid+1;
            else{
                right=mid;
            }

        }
    return left;
    }
}