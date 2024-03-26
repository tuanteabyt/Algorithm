public class Solution {
    public int MaximumPopulation(int[][] logs) {
        int[] dp= new int [101];
        int sum=0,max=0,year=0 ;
        for(int i=0;i<logs.Length;i++){
                dp[logs[i][0]-1950]++;
                dp[logs[i][1]-1950]--;
        }
        for(int i=0;i<101;i++){
                sum+=dp[i];
                if(sum>max) year=i;
                max=max>sum?max:sum;
                
        }
        return year+1950;
        
    }
}