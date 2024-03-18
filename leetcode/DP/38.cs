public class Solution {
    public string CountAndSay(int n) {
        string num = "1";

        for(int i=0; i< n-1; i++){
            Console.WriteLine(num);
            num = word(num);
        }
        return num;
    }

    public string word(string num){
        string ans ="";
        char current = num[0];
        int charCount=0;
         for(int i=0; i< num.Length; i++){
             if (num[i] == current){
                 charCount++;
             }else{
                 ans += charCount.ToString() + current;
                 current = num[i];
                 charCount =1;
             }
        }
         ans += charCount.ToString() + current;
        return ans;
    }
    //  public string CountAndSay(int n)
    // {
    //     if (n == 1) return "1";
    //     string result = "1";
    //     for (int i = 1; i < n; i++)
    //     {
    //         StringBuilder sb = new StringBuilder();
    //         char prev = result[0];
    //         int count = 1;
    //         for (int j = 1; j < result.Length; j++)
    //         {
    //             if (result[j] == prev)
    //             {
    //                 count++;
    //             }
    //             else
    //             {
    //                 sb.Append(count).Append(prev);
    //                 prev = result[j];
    //                 count = 1;
    //             }
    //         }
    //         sb.Append(count).Append(prev);
    //         result = sb.ToString();
    //     }
    //     return result;
    // }
    // public string CountAndSay(int n) {
    //     string result="1";
    //     if(n==1) return result;
    //     int [][]dp=new int[10000][];
    //     for(int i=0;i<10000;i++){
    //         dp[i]=new int [2];
    //     }
    //      for(int i=0;i<n-1;i++){
    //         dp=helper(result,dp);
    //         result=helper1(dp);
    //     }
    //     return result;
    //     }
    //  public int[][] helper(string s,int[][] dp){
    //     int count=0;
    //     dp[0]=[s[0]-'0',1];
    //     for(int i=1;i<s.Length;i++){
    //       if(s[i]-'0'==dp[count][0]){
    //         dp[count][1]=dp[count][1]+1;
    //       }
    //       else
    //       {
    //        count++;
    //        dp[count]=[s[i]-'0',1];
    //       }
    //     }
    //     return dp;
    // }
    //  private string helper1(int[][]dp){
    //     string a="";
    //     for(int i=0;i<dp.Length;i++){           
    //         for(int j=1;j>=0;j--){
    //         if(dp[i][j]==0) break;
    //         a+= dp[i][j].ToString();
    //         }
    //     }
    //    return a;
    // }
}