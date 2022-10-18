public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        
        // Default
        if (gas.Length == 1)
        {
            if (gas[0] >= cost[0])
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        
        List<int> Gas  = gas.ToList();
        List<int> Cost = cost.ToList();
        
        int Tank       = 0;
        int StartIndex = 0;
        
        while (StartIndex < Gas.Count)
        {
            Tank = Gas[0];
            
            // Debug
            for (int k = 0; k < Gas.Count; k++)
            {
                Console.Write(Gas[k] + ", ");
            }
            Console.Write("\n");
            for (int k = 0; k < Cost.Count; k++)
            {
                Console.Write(Cost[k] + ", ");
            }
            Console.Write("\n\n");  
            //////////////////////////////////////**/
            
            for (int i = 1; i < Gas.Count; i++)
            {   
                Tank -= Cost[i - 1];
                
                if (Tank <= 0)
                {
                    break;
                }
                
                Tank += Gas[i];
                
                if (i == (Gas.Count - 1) && Tank >= Cost[i])
                {
                    //Console.WriteLine("Tank: " + Tank);
                    //Console.WriteLine("Cost: " + Cost[i]);
                    
                    return StartIndex;
                }
            } 
            
            int NxtGasIndex = Gas.FindIndex(x => x != Gas[0]);
            int NxtCostIndex = Cost.FindIndex(x => x != Cost[0]);
            
            if (NxtGasIndex == -1)
            {
                NxtGasIndex = int.MaxValue;
            }
            
            if (NxtCostIndex == -1)
            {
                NxtCostIndex = int.MaxValue;
            }
            
            int NextIndex = Math.Min(NxtGasIndex, NxtCostIndex);
            
            Gas.AddRange(Gas.GetRange(0, NextIndex));
            Gas.RemoveRange(0, NextIndex);
            
            Cost.AddRange(Cost.GetRange(0, NextIndex));
            Cost.RemoveRange(0, NextIndex);
            
            StartIndex += NextIndex;    
        }
        
        return -1;
    }

}