public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         IDictionary<int, int> hashMap = new Dictionary<int, int>();
         int[] ans=new int[k];
        for(int i;i<nums.Length;i++)
        {
        hashMap[nums[i]]=hashMap.GetValueOrDefault(nums[i], 0)+1;
        }
        foreach(var item in map.OrderByDescending(item => item.Value)) {
            k -= 1;
            if(k >= 0)
                ans[k] = item.Key;
            else
                break;
        }
        return ans;
        
    }
}