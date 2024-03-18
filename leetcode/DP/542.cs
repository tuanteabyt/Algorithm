public class Solution {
    public int[][] UpdateMatrix(int[][] mat) {
        int m = mat.Length;
        int n = mat[0].Length;
        int max=m+n;
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<n;j++){
                if(mat[i][j]==0) continue;
                int top=max,left=max;
                if(i>0) top=mat[i-1][j];
                if(j>0) left=mat[i][j-1];   
                mat[i][j]=Math.Min(top,left)+1;
            }       
        }
        for(int i=m-1;i>=0;i--){
            for(int j=n-1;j>=0;j--){
                if(mat[i][j]==0) continue;
                int right=max,bottom=max;
                if(i<m-1) right=mat[i+1][j];
                if(j<n-1) bottom=mat[i][j+1];   
                mat[i][j]=Math.Min(mat[i][j],Math.Min(right,bottom)+1);     
            }       
        }
        return mat;
    }
}
// khi chua xac dinh dk ptu ke thi chia ra theo 2 chieu