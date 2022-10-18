public class Solution {
    public int ClimbStairs(int n) {
        
        // Default
        if (n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        
        int DPTwo = 1;
        int DPOne = 1;
        
        int Current = 0;
        
        for (int i = 2; i <= n; i++)
        {            
            Current = DPOne + DPTwo;

            DPTwo = DPOne;
            DPOne = Current;
        }
        
        return Current;
    }

}