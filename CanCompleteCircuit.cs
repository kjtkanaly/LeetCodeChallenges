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
        
        for (int j = 0; j < Gas.Count; j++)
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
                //Console.WriteLine("Tank: " + Tank);
                
                Tank -= Cost[i - 1];
                
                if (Tank <= 0)
                {
                    break;
                }
                
                Tank += Gas[i];
                
                if (i == (Gas.Count - 1) && Tank >= Cost[i])
                {
                    Console.WriteLine("Tank: " + Tank);
                    Console.WriteLine("Cost: " + Cost[i]);
                    
                    return StartIndex;
                }
            } 
            
            Gas = CircShiftCCW(Gas);
            Cost = CircShiftCCW(Cost);
            StartIndex++;
        }
        
        return -1;
    }
    
    public List<int> CircShiftCCW(List<int> Input)
    {
        Input.Add(Input[0]);
        
        Input.RemoveAt(0);
        
        return Input;
    }
}