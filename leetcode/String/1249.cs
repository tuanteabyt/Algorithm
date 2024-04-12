public class Solution {
    public string MinRemoveToMakeValid(string s) {
        int left=0,right=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='('){
                left++;
            }
            if(s[i]==')'){
                right++;
                if(right>left)  {
                    s=s.Remove(i,1);
                    right--;
                    i=i-1;
                    }
            }
        }
        for(int i=s.Length-1;i>=0;i--){
            if(s[i]=='('&&left-right>0){
               s=s.Remove(i,1);
               left--;
               //i=i+1;
            }
            }
        return s;
    }
}