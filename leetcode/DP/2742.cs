public class Solution
{
    long[,] dp;
    public int PaintWalls(int[] cost, int[] time)
    {
        int n = cost.Length;
        dp = new long[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                dp[i, j] = -1;
            }
        }
        long res = F(cost, time, 0, 0);
        return (int)res;
    }
    public long F(int[] cost, int[] time, int i, int j)
    {
        //i la buc tuong dang chon
        //j  la so buc da son dk vuot qua mang time thi return 0
        if (j >= cost.Length)
        {
            return 0;
        }
        // neu vuot qua mang thi cho no la int max
        if (i == cost.Length)
        {
            return int.MaxValue;
        }
        // neu dp[i,j] da tinh roi thi return luon
        if (dp[i, j] != -1)
        {
            return dp[i, j];
        }
        //dp[i,j]=nhan cong i+1 va cong i or nhan cong i+1 or chi nhan i+1
        dp[i, j] = Math.Min(cost[i] + F(cost, time, i + 1, j + 1 + time[i]), F(cost, time, i + 1, j));
        return dp[i, j];
    }
}