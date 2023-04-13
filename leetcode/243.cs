public class Solution {
    public bool IsAnagram(string s, string t) {
        int n=s.Length,m=t.Length;
        if(n!=m) return false;
        int[] store=new int[26];

        for(int i=0;i<m;i++)
         {
             store[s[i]-'a']++;
             store[t[i]-'a']--;
         }
         foreach (int a in store) if (a != 0) return false;
        return true;
    }
}