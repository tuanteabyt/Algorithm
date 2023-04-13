public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> myhash1 = new HashSet<int>();
        foreach(int i in nums){
            if ( myhash1.Contains(i))
              return true;
            myhash1.Add(i);
        }
     return false;
    }
}