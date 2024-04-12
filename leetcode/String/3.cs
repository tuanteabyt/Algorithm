public class Solution {
    public int LengthOfLongestSubstring(string s) {
         Dictionary<char, int> My_dict = new Dictionary<char, int>();
        int left=0,right=0,n=s.Length,result=0;
        while(right<n){
            if(!My_dict.ContainsKey(s[right])) {
                My_dict.Add(s[right],1);
            }
            else{
               My_dict[s[right]]++;
            }
            while(My_dict[s[right]]>1){
               My_dict[s[left]]--;
               left++;
            }
            result=Math.Max(result,right-left+1);
            right++;
        }
        return result;
    }
}