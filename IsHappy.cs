public class Solution {
    public bool IsHappy(int n) {
        
        // Default
        if (n == 0)
        {
            return false;
        }
        
        int Sum = 0;
        List<int> Prev = new List<int>();
        
        while (n != 1)
        {
            int[] N   = n.ToString().Select(o=> Convert.ToInt32(o) - 48 ).ToArray();    
            n = N.Select(x => (int)Math.Pow(x, 2)).ToArray().Sum();   
            
            if (Prev.Contains(n))
            {
                return false;
            }
            
            Prev.Add(n);
            Console.WriteLine(n);
        }
        
        return true;
    }
}