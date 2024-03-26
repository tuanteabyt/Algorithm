public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] dp =new int[26];
        int temp1=1,temp2;
        for(int i=0;i<tasks.Length;i++){
            dp[tasks[i]-'A']++;
        }
        Array.Sort(dp, (a, b) => b.CompareTo(a));
        for(int i=1;i<26;i++){
            if(dp[i]==dp[0]){
                temp1++;
            } 
             if(dp[i]==0){
                i=26;
            }           
        }
        temp2=(dp[0]-1)*(n+1)+temp1;

        return Math.Max(temp2,tasks.Length);
    }
}