public class Solution
{
	int[,] dp;
	public int SuperEggDrop(int k, int n)
	{
		dp = new int[k + 1, n + 1];
		for (int i = 0; i < k + 1; i++)
		{
			for (int j = 0; j < n + 1; j++)
			{
				dp[i, j] = -1;
			}
		}
		return slove(k, n);
	}
	public int slove(int k, int n)
	{
		if (k == 1)
		{
			return n;
		}
		//nếu n==1 hoặc 0 thì return n
		if (n <= 1)
		{
			return n;
		}
		if (dp[k, n] != -1)
		{
			return dp[k, n];
		}
		int min = int.MaxValue;
		int l = 1, r = n;
		while (l <= r)
		{
			int m = (l + r) / 2;
			// neu tha tu tang giua thi se vo hoac k vo
			//neu vo
			int down = slove(k - 1, m - 1);
			// khong vo
			int up = slove(k, n - m);
			//max cua th khi vo hoac k vo
			int temp = 1 + Math.Max(down, up);
			if (down < up)
			{
				//neu down nho hon thi tang left len
				l = m + 1;
			}
			//neu down lon hon thi giam right xuong boi vi min khi down xap xi left
			else
			{
				r = m - 1;
			}
			min = Math.Min(min, temp);
		}
		return dp[k, n] = min;
	}
}