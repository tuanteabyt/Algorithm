public class Solution {
    public int NthUglyNumber(int n) {
        int[] k=new int[n];
        k[0]=1;
        int t2 = 0, t3 = 0, t5 = 0;
        for(int i=1;i<n;i++)
        {    k[i] = Math.Min(k[t2]*2,Math.Min(k[t3]*3,k[t5]*5));
            if(k[i] == k[t2]*2) t2++; 
            if(k[i] == k[t3]*3) t3++;
            if(k[i] == k[t5]*5) t5++;
        }
        return k[n-1];
    }
}