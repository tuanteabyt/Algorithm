public class Solution
{
    public int NumberOfWays(int startPos, int endPos, int k)
    {
        int count = (endPos > startPos) ? (endPos - startPos) : (startPos - endPos);
        if (k < count) return 0;
        if ((k - count) % 2 == 1) return 0;
        int step = count + (k - count) / 2;
        long max = 1L, min = 1L;
        int modulo = 1000000007;
        int a = 0;
        int temp = (k > 2 * step) ? step : k - step;
        for (int i = k; i > k - temp; i--)
        {
            max = (max * i) % modulo;
            min = min * (k + 1 - i) % modulo;
            a++;
        }
        long result = max % modulo;
        long divisor = min % modulo;

        // Tính phần tử nghịch đảo của divisor theo modulo
        long inverseDivisor = ModInverse(divisor, modulo);

        // Tính kết quả cuối cùng
        long finalResult = ((result * inverseDivisor) % modulo);

        return (int)finalResult;
    }
    //tim uocchunglonnhan giua A va M khi va khi y==0 ta di tim x
    private long ModInverse(long a, long m)
    {
        long m0 = m;
        long y = 0, x = 1;

        if (m == 1)
            return 0;

        while (a > 1)
        {
            long q = a / m;
            long t = m;
            m = a % m;
            a = t;
            // x= x0-x1*q y la x1 va x la x0
            t = y;
            y = x - q * y;
            x = t;
        }

        if (x < 0)
            x += m0;

        return x;
    }
}