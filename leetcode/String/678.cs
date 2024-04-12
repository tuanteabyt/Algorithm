public class Solution {
    public bool CheckValidString(string s) {
        int left=0,right=0,tmp=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('||s[i]=='*'){
                left++;
            }
            else{
             left--;
            }
            if(s[s.Length-i-1]==')'||s[s.Length-i-1]=='*'){
                right++;
            }
            else{
                right--;
            }
            if(left<0||right<0) return false;

        }
        return true;
    }
}