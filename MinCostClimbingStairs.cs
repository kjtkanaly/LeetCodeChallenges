public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        
        if (cost[0] == 0)
        {
            List<int> Cost = cost.ToList();
            Cost.RemoveAt(0);
            cost = Cost.ToArray();
        }
        
        if (cost[cost.Length - 1] == 0)
        {
            List<int> Cost = cost.ToList();
            Cost.RemoveAt(cost.Length - 1);
            cost = Cost.ToArray();
        }
        
        if (cost.Length == 3)
        {
            return Math.Min(cost[2]+cost[0], cost[1]);
        }
        
        // Check for cheapest path to the left
        int index = cost.Length;
        int LeftTotal = 0;
        
        while (index >= 2)
        {
            if (cost[index - 1] < cost[index - 2])
            {
                index -= 1;
                LeftTotal += cost[index];
            }
            else
            {
                index -= 2;
                LeftTotal += cost[index];
            }
            
            Console.WriteLine("Index: " + index);
        }
        
        // Check for cheapest path to the right
        index = -1;
        int RightTotal = 0;
        
        while (index < cost.Length - 2)
        {
            if (cost[index + 1] < cost[index + 2])
            {
                index += 1;
                RightTotal += cost[index];
            }
            else
            {
                index += 2;
                RightTotal += cost[index];
            }
            
            Console.WriteLine("Index: " + index);
        }
        
        
        return Math.Min(LeftTotal, RightTotal);
    }
}