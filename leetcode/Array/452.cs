public class Solution {
    public int FindMinArrowShots(int[][] points) {
        Array.Sort(points, (x, y) => x[0].CompareTo(y[0]));
        int count=1;
        int minx=points[0][0];
        int maxx=points[0][1];
        for(int i=1;i<points.Length;i++){
            if(points[i][0]<=maxx){
                minx=points[i][0];
                if(points[i][1]<maxx){
                maxx=points[i][1];
                }
            }
            else{
                minx=points[i][0];
                maxx=points[i][1];
                count++;
            }
        }
        return count;
    }
}