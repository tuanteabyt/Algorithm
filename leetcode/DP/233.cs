public class Solution
{
    int[] dp;
    public int CountDigitOne(int n)
    {
        long count = 0;
        for (long i = 1; i <= (long)n; i *= 10)
        {
            long i10 = i * 10;
            //tinh so 1 o tung hang don vi se bang so lan xuat hien cua no tren no hàng chuc va so lan xuan hien lai no o hang voi no.
            count += (n / i10) * i + Math.Max((long)0, Math.Min(i, n % i10 - (i - 1)));
        }
        return (int)count;
    }
}