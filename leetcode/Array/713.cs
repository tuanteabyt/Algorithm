public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
         int left = 0, right = 0,sum=1,count=0;

         while(right < nums.Length) {
            sum*=nums[right];
           while (left<=right && sum>=k) {
                sum=sum/nums[left++];

    }
    count+=right-left+1;      //tính thêm một mảng con khi tăng lên
    right++;
}
return count;
    }
}