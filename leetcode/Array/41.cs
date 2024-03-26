public class Solution {
    public int FirstMissingPositive(int[] nums) {
        // Hashtable result = new Hashtable();
        // int ans=0;
        // for(int i=0;i<nums.Length;i++){
        //     if(!result.ContainsKey(nums[i]))
        //     result.Add(nums[i],1);
        // }
        // for(int i=1;i<=nums.Length+1;i++){
        //     if(!result.ContainsKey(i)){
        //         ans=i;
        //         i=nums.Length+1;
        //     }
        // }
        // return ans;
         var i=0;
        while(i<nums.Length){
            if( nums[i] <= 0 || nums[i] >= nums.Length || nums[nums[i]-1] == nums[i]){
                i++;
                continue;
            }

            var swap = nums[i];
            var temp = nums[nums[i]-1];
            nums[i] = temp;
            nums[swap-1] = swap;
        }

        for(i=0; i<nums.Length; i++){
            if(i != nums[i]-1)
                return i+1;
        }

        return nums.Length+1;
    }
}