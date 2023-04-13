public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> prevMap = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int diff = target - num;

            if (prevMap.ContainsKey(diff)) {
                return new int[] { prevMap[diff], i };
            }
             if (prevMap.ContainsKey(num)) {
                prevMap[num]= i ;
            }
            else
            prevMap.Add(num, i);
        }

        return new int[] {};
    }
}