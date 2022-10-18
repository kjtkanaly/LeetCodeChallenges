public class Solution {
    public bool IsPalindrome(int x) {
        
        if (x < 0)
        {
            return false;
        }
        
        int xOG = x;
        int xFlipped = 0;
        
        int length = x.ToString().Length;
        
        for (int i = 0; i < length; i++)
        {
            xFlipped *= 10;
            xFlipped += x % 10;

            x /= 10;
        }
        
        if (xFlipped == xOG)
        {
            return true;
        }
        else
        {
            return false;   
        }
    }
}