public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        //     IList<int> results =new List<int>();
        //     Hashtable hash = new Hashtable();
        //     for(int i=0;i<nums.Length;i++){
        //         if(hash.ContainsKey(nums[i])){
        //             results.Add(nums[i]);
        //         }
        //         else{
        //             hash.Add(nums[i],1);
        //         }
        //     }
        // return results;
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] < 0) result.Add(Math.Abs(index + 1));
            nums[index] = -nums[index];
        }
        return result;
    }
}