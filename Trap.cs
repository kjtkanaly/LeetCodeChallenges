public class Solution {
    public int Trap(int[] height) {
        
        // Default
        if (height.Length <= 2)
        {
            return 0;
        }
        
        int i = 0, j = height.Length, water = 0, currentI;
        
        int maxHeight = height.Max();
        int target    = maxHeight;
        
        while (target > 0)
        {   
            // Check to the right
            int left = Array.IndexOf(height, maxHeight);            
            int right = left + 1;            
            
            while (right < j)
            {
                if (height[right] >= target)
                {
                    water += (right - left - 1);
                    left = right;
                }
                right++;
            }
            
            // Check to the left
            right = Array.IndexOf(height, maxHeight);            
            left = right - 1;
            
            while (left > -1)
            {
                if (height[left] >= target)
                {
                    water += (right - left - 1);
                    right = left;
                }
                left--;
            }
            
            // Lower target
            target--;
            
        }
            
        return water;
    }
}