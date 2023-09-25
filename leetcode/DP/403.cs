public class Solution
{
	Dictionary<int, int> mark = new Dictionary<int, int>();
	int[,] dp = new int[2000, 2000];
	public bool solve(int[] stones, int n, int index, int prevJump)
	{  //neu o vi tri cuoi cung thi cau tra loi la tru
		if (index == n - 1)
		{
			return true;
		}
		//neu co the di qua trang thai nay thi tra ve tru or false
		if (dp[index, prevJump] != -1)
		{
			return dp[index, prevJump] == 1;
		}
		bool ans = false;
		// kt xem co di qua vi tri index vs buoc nhay la prevJump k
		for (int nextJump = prevJump - 1; nextJump < prevJump + 2; nextJump++)
		{
			if (nextJump > 0 && mark.ContainsKey(stones[index] + nextJump))
			{
				ans = ans || solve(stones, n, mark[stones[index] + nextJump], nextJump);
			}
		}
		dp[index, prevJump] = (ans ? 1 : 0);
		return ans;
	}
	public bool CanCross(int[] stones)
	{
		//them vi tri va do cao tung vien da
		for (int i = 0; i < stones.Length; i++)
		{
			mark.Add(stones[i], i);
		}
		//cho moi gia tri cua mang la -1
		for (int i = 0; i < 2000; i++)
		{
			for (int j = 0; j < 2000; j++)
			{ dp[i, j] = -1; }
		}
		return solve(stones, stones.Length, 0, 0);
	}
}
//public class Solution
//{
//	HashSet<int> lookup;
//	Dictionary<string, bool> dp;

//	public bool CanCross(int[] stones)
//	{
// neu nhu vi tri thu 1 khac 1 thi tra ve false
//		if (stones[1] != 1)
//			return false;

//		lookup = new();
//		dp = new();

//		for (int i = 0; i < stones.Length; i++)
//			lookup.Add(stones[i]);

//		return DetemineCanCross(1, 1, stones[stones.Length - 1]);
//	}

//	private bool DetemineCanCross(int reachedUnits, int lastStep, int destination)
//	{
// neu nhu nhay den ma k o tren da thi tra ve false
//		if (!lookup.Contains(reachedUnits))
//			return false;
//neu dich den bang vi tri dat dk thi tra ve true
//		if (reachedUnits == destination)
//			return true;
// neu da chua trang thai nay thi tra ve
//		string localLookup = reachedUnits + "~" + lastStep;
//		if (dp.ContainsKey(localLookup))
//			return dp[localLookup];

//		if (lastStep == 0)
//		{
//			bool computedResult = DetemineCanCross(reachedUnits + 1, 1, destination);
//			dp.Add(localLookup, computedResult);
//			return computedResult;
//		}
// neu nhu buoc nhay la 1 thi buoc nhay tiep theo la 2 hoac 1
//		if (lastStep == 1)
//		{
//			bool computedResult = DetemineCanCross(reachedUnits + 1, 1, destination) ||
//								  DetemineCanCross(reachedUnits + 2, 2, destination);
//			dp.Add(localLookup, computedResult);
//			return computedResult;
//		}
//		else
//		{
//			bool computedResult = DetemineCanCross(reachedUnits + lastStep - 1, lastStep - 1, destination) ||
//								  DetemineCanCross(reachedUnits + lastStep, lastStep, destination) ||
//								  DetemineCanCross(reachedUnits + lastStep + 1, lastStep + 1, destination);
//			dp.Add(localLookup, computedResult);
//			return computedResult;
//		}
//	}
//}