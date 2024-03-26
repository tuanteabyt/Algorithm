public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count=0;
        for(int i=0;i<nums.Length;i++){
          nums[i-count]=nums[i];
          if(nums[i]==val)
          {
          count++;}
        }
        return nums.Length-count;
    }
}