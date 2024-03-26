public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Hashtable a=new Hashtable();
        for(int i=0;i<s.Length;i++){
        if(!a.ContainsKey(s[i])&&!a.ContainsValue(t[i])){
            a.Add(s[i],t[i]);
        }
        else{
            if(!t[i].Equals(a[s[i]])) return false; 
        }
        }
        return true;
    }
}