public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int count=0;
        String s1="";
        for(int i=0;i<s.Length;i++)
            if(s[i]=='1') count++;
        for(int i=0;i<s.Length-1;i++)
        { if(count-1>0) 
        { s1=s1+"1";
          count--;
        }
         else s1=s1+"0";
        }
        s1=s1+"1";
        return s1;
    }
}