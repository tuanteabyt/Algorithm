public class Solution {
    public bool CanIWin(int maxChoosableInteger, int desiredTotal) {
        int sum = maxChoosableInteger * (maxChoosableInteger + 1)/2;
        if(sum < desiredTotal) return false;
        if(desiredTotal <= 0) return true;

        return CanIWin(desiredTotal, new Dictionary<int, bool>(), new bool[maxChoosableInteger + 1], 0); 
    }

    private bool CanIWin(int desiredTotal, Dictionary<int, bool> memo, bool[] visited, int state) {
        if(desiredTotal <= 0) return false;   
   
        if(memo.ContainsKey(state)) return memo[state];// đã qua trạng thái này chưa

        for(int i = 1; i < visited.Length; i++) {
            if(!visited[i]) {// chưa chọn i
                visited[i] = true;//chọn i
                if(!CanIWin(desiredTotal - i, memo, visited, 1 << i | state)) {//k chon i và k thể win
                    memo.Add(state, true);//state true
                    visited[i] = false;// chưa thăm i để tính các th khác xảy ra
                    return true; //trả về true
                }
                visited[i] = false;//k thăm i
            }   
        } 

        memo.Add(state, false);// false
        return false; //return false
    }
}