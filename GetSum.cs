public class Solution {
    public int GetSum(int a, int b) {
        
        int count = 0;
        
        for (int i = 0; i < Math.Abs(a); i++)
        {
            if (a > 0)
            {
                count++;    
            }
            else
            {
                count--;
            }
        }
        
        for (int i = 0; i < Math.Abs(b); i++)
        {
            if (b > 0)
            {
                count++;    
            }
            else
            {
                count--;
            }
        }
        
        return count;
    }
}