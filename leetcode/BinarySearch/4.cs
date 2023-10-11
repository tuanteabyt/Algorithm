public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n=nums1.Length,m=nums2.Length,p1=0,p2=0,p=0;
        int [] nums=new int[n+m];
        while(p1<n&&p2<m){
            if(nums1[p1]<nums2[p2]){
                nums[p]=nums1[p1];
                p++;
                p1++;
            }
            else{
                nums[p]=nums2[p2];
                p++;
                p2++;
            }
        }
        while(p1<n)
        {
            nums[p]=nums1[p1];
            p++;
            p1++;
        }
          while(p2<m)
        {
            nums[p]=nums2[p2];
            p++;
            p2++;
        }
        if((n+m)%2==1) return nums[(n+m)/2];
        else return (double)(nums[(n+m)/2-1]+nums[(n+m)/2])/2;
    }
}