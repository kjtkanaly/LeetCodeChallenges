public class Solution {
    
    public int MinCostClimbingStairs(int[] cost) {
        
        // Default
        if (cost.Length == 2)
        {
            return Math.Min(cost[0], cost[1]);
        }
            
        
        int DP_One = cost[1];
        int DP_Two = cost[0];
        
        int current = 0;
        
        for(int i = 2; i < cost.Length; i++)
        {
            current = cost[i] + Math.Min(DP_One, DP_Two);
            
            DP_Two = DP_One;
            DP_One = current;
        }
        
        return Math.Min(DP_Two, current);
    }
    
}