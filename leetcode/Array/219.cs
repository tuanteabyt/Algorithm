public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Hashtable a=new Hashtable();
     for(int i=0;i<nums.Length;i++){
        if(!a.ContainsKey(nums[i])){
            a.Add(nums[i],i);
        }
        else{
            if(k>=i-(int)a[nums[i]]) return true;
            else a[nums[i]]=i;
        }
        
     }
    return false;
    }
}