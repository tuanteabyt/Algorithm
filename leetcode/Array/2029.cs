public class Solution {
    public bool StoneGameIX(int[] stones) {
        int n=stones.Length;
        int [] cnt=new int[3];
        if(n==1) return false;
        for(int i=0;i<n;i++){
            cnt[stones[i]%3]++;
        }
        if (Math.Min(cnt[1], cnt[2]) == 0)
            return Math.Max(cnt[1], cnt[2]) > 2 && cnt[0] % 2 > 0;
        return Math.Abs(cnt[1] - cnt[2]) > 2 || cnt[0] % 2 == 0;

    }
}
// If cnt[1] == 0, Alice needs to start with mod3 = 2,
// If cnt[2] == 0, Alice needs to start with mod3 = 1.
// Alice can win if max(cnt[1], cnt[2]) > 2 && cnt[0] % 2 > 0,
// for example [1,1,1,3].

// If cnt[0] % 2 == 0, easy case for Alice.
// Alice can win in at leasy one of the two options, picking the less one.

// Otherwise cnt[0] % 2 == 1, this will reverse the result.
// If abs(cnt[1] - cnt[2]) > 2,
// Alice will pick mod3=2 if mod3=2 is more
// Alice will pick mod3=1 if mod3=1 is more
// If abs(cnt[1] - cnt[2]) <= 2,
// Alice will lose for no number remaining.
