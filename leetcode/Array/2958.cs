public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        int n=nums.Length,max=0,i=0;
        Dictionary<int,int> a=new Dictionary<int,int>();
            for(int j=0;j<n;j++){
                if(!a.ContainsKey(nums[j])){
                   a.Add(nums[j],1);
                }
                else{
                    a[nums[j]]++;
                }
                while(a[nums[j]]>k) {
                 a[nums[i]]--;
                 i++;
                }//tăng i lên để tìm mảng con hợp lệ
            max = Math.Max(max, j - i + 1);//update lai max
        }
        return max;
    }
}