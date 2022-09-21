public class Solution {
    
    public List<int> Counts = new List<int>();
    public bool Dig = true;
    
    public int CoinChange(int[] coins, int amount) {
        
        int Count = 0;
        
        Array.Sort(coins);
        Array.Reverse(coins);
        
        Count = SubtractCoin(amount, 0, coins);
        
        /*while (amount > 0)
        {
            bool Change = false;
            
            for (int i = 0; i < coins.Length; i++)
            {
                if (amount - coins[i] > -1)
                {
                    amount -= coins[i];
                    Count++;
                    Change = true;
                    break;
                }
            }
            
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Count: " + Count);
            
            if (Change == false)
            {
                return -1;
            }
        }*/
        
        return Count; 
    }
    
    public int SubtractCoin(int Goal, int Value, int[] coins, int count = 0)
    {
        Console.WriteLine(Value);
        
        if (Value == Goal)
        {
            Counts.Add(count);
            Console.WriteLine(count);
            Dig = false;
            return count;
        }
        
        for (int i = 0; i < coins.Length; i++)
        {
            if (Value + coins[i] <= Goal && Dig == true)
            {
                return Math.Max(SubtractCoin(Goal, Value + coins[i], coins, count++), count);
            }
        }
        
        return -1;
    }
}