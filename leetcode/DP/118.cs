public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> rs = new List<IList<int>> { new List<int> { 1 } };
        for (int i = 2; i <= numRows; i++)
        {
            // tao 1 o dau mang
            var list = new List<int> { 1 };
            for (int j = 1; j < i - 1; j++)
            {
                //phan tu tiep theo bang rs[i-1][j-1]+rs[i-1][j]
                list.Add(rs[rs.Count - 1][j - 1] + rs[rs.Count - 1][j]);
            }
            //them 1 cuoi danh sanh
            list.Add(1);
            //them bao IList
            rs.Add(list);
        }
        return rs;
    }
}