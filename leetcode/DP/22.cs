public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        Dictionary<int,List<string>> result = new Dictionary<int,List<string>>();
        result.Add(1, new List<string>{"()"});
        result.Add(2, new List<string>{"(())", "()()"});
         for (int i = 3; i <= n; i++)
        {
            GenerateParenthesis(i, result);
        }
        return result[n];
    }
        private List<string> GenerateParenthesis(int n, Dictionary<int, List<string>> result)
    {
        if(result.ContainsKey(n)) return result[n];
        var set= new HashSet<string>();
        var prev= GenerateParenthesis(n-1,result);
        for(int i=0;i<prev.Count;i++){
            set.Add("("+prev[i]+")");
        }
          for (int i = 1; i < n; i++)
        {
            var firstPart = GenerateParenthesis(i, result);
            var secondPart = GenerateParenthesis(n - i, result);
            for (int j = 0; j < firstPart.Count; j++)
            {
                for (int k = 0; k < secondPart.Count; k++)
                {
                    if (!set.Contains(firstPart[j] + secondPart[k])) set.Add(firstPart[j] + secondPart[k]);
                }
            }
        }
        var rs = set.ToList();
        if (!result.ContainsKey(n)) result.Add(n, rs);
        return rs;
    }
}