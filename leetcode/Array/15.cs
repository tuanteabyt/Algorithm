public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> a= new List<IList<int>>();
        Array.Sort(nums);
        int n=nums.Length;
        for(int i =0;i<n-2;i++){
        int right=n-1;
        int left =i+1;
        while(left<right){
        int numsleft = nums[left];
        int numsright = nums[right];
        if(nums[i]+nums[left]+nums[right]<0) left++;
        else if(nums[i]+nums[left]+nums[right]>0) right--;   
        else
        {
        a.Add([nums[i], nums[left], nums[right]]);
        if(nums[left]==nums[right]) break;
        while (left < right && nums[left] == numsleft)
                        left++;
        while (left < right && nums[right] == numsright)
                        right--;
        while (left < right && nums[right] == numsright)
                        right--;
        }
        }
        while(i<n-2&&nums[i]==nums[i+1]) i++;
        }
        return a;
    }
}