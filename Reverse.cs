public class Solution {
    public int Reverse(int x) {
        
        int modifier = 1;
        int output = 0;
        
        if (x < 0)
        {
            x *= -1;
            modifier = -1;
        }
        
        int length = x.ToString().Length;
        
        for (int i = 0; i < length; i++)
        {
            int singlesValue = x % 10;
            
            output *= 10;
            output += singlesValue;
            
            if (singlesValue != output % 10)
            {
                return 0;
            }
            
            x /= 10;
        }
        
        output *= modifier;
        
        return output;      
    }
}