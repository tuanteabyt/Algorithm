public class Solution {
    public string MakeGood(string s) {
        Stack myStack=new Stack();
        for(int i=0;i<s.Length-1;){
           // if(i<0) break;
            // if((Char.ToUpper(s[i]).Equals(s[i+1])||Char.ToUpper(s[i+1]).Equals(s[i]))&&!s[i+1].Equals(s[i]))
            // {
            //     s=s.Remove(i,2);
            //     i=i-2>0?i-1:0;
            // }
            if(Math.Abs(s[i]-s[i+1])==32)
            {
                s=s.Remove(i,2);
                i=i-2>0?i-1:0;
            }
            else{
                i++;
            }
        }
        return s;
    }
}