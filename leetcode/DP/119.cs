public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        // IList<IList<int>> rs=new  List<IList<int>>{new List<int>{1}};
        // List<int> list=new List<int>{1};
        //  for (int i = 2; i <= rowIndex+1; i++)
        // { 
        //     // tao 1 o dau mang
        //     list = new List<int>{1};
        //     for (int j = 1; j < i - 1; j++)
        //     {   
        //         //phan tu tiep theo bang rs[i-1][j-1]+rs[i-1][j]
        //         list.Add(rs[rs.Count - 1][j - 1] + rs[rs.Count - 1][j]);
        //     }
        //     //them 1 cuoi danh sanh
        //     list.Add(1);
        //     //them bao IList
        //     rs.Add(list);
        // }
        // return list;
        int[] row = new int[rowIndex + 1];
        row[0] = 1;
        for (int i = 0; i <= rowIndex; i++)
        {
            for (int j = i; j > 0; j--)
            {
                row[j] += row[j - 1];
            }
        }
        return row;
    }
}