public class Solution {
    public double MyPow(double x, int n) {
     
        // Default
        if (x == 0 || Math.Abs(x) == 1)
        {
            if (n % 2 == 0)
            {
                return Math.Abs(x);    
            }
            else
            {
                return x;
            }
        }
        
        double pow = 1;
        
        if (n > 0)
        {
            for (int i = 0; i < n; i++)
            {
                pow *= x;
            }
        }
        else
        {
            for (int i = 0; i > n; i--)
            {
                pow /= x;
                
                if (pow == 0)
                {
                    return 0;
                }
            }   
        }        
        
        return pow;
        
    }
}