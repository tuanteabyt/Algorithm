public class Solution {
    public int TwoCitySchedCost(int[][] costs) {
        PriorityQueue<int[],int> pq=new();
        foreach(var cost in costs){
            int diff=cost[0]-cost[1];
            pq.Enqueue(cost,diff);
        }
        int n = costs.Length/2;
        int minCost = 0;
        for(int i=0; i<costs.Length; i++){
            var cost = pq.Dequeue();
            if(i<n){
                minCost += cost[0];
            }else{
                minCost += cost[1];
            }
        }
        return minCost;
    }
}