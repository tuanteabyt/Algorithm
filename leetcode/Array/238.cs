public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n=nums.Length;
        int multi=1, count=0;
        for(int j=0;j<n;j++){
            if(nums[j]==0&&count<1){
                count++;
                continue;
            }
            multi=multi*nums[j];
        }
         for(int j=0;j<n;j++){
            if(count==0)
            nums[j]=multi/nums[j];
            else{
                if(nums[j]!=0)
                nums[j]=0;
                else
                nums[j]=multi;

            }
        }
        return nums;
    }
}