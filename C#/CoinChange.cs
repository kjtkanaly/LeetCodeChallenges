public class Solution {
    
    public List<int> Counts = new List<int>();
    
    public int CoinChange(int[] coins, int amount) {
        
        Array.Sort(coins);

        int total = 0;
        int Count = Branch(coins, 0, amount);
        
        
        
        return Count;
    }
    
    public int Branch(int[] coins, int total, int goal, int count = 0)
    {
        
        if (total == goal)
        {
            Console.WriteLine(count);
            //Counts.Add(count);
            return count;
        }
        else if (total > goal)
        {
            return -1;
        }
        else
        {
            for (int i = coins.Length - 1; i > -1; i--)
            {
                
                int Depth = Branch(coins, total + coins[i], goal, count + 1);
                //Console.WriteLine(Depth);
                
                if (Depth != -1)
                {
                    return Depth;
                }
                
            }
        }
        
        return -1;
    }
    
}