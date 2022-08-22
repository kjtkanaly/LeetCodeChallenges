public class Solution {
    public int Trap(int[] height) {
        
        // Default
        if (height.Length <= 2)
        {
            return 0;
        }
        
        int water = 0;
        int target = 1;
        int start = Array.FindIndex(height, item => item > 0);
        int end = Array.FindLastIndex(height, item => item > 0);
        
        // Getting local peaks
        while (start < end)
        {                
            for (int index = start + 1; index < end; index++)
            {
                if (height[index] <= 0)
                {
                    water++;
                }
                
                height[index]--;
            }
            
            height[start]--;
            height[end]--;
            
            start = Array.FindIndex(height, item => item > 0);
            end = Array.FindLastIndex(height, item => item > 0);
        }
            
        return water;
    }
}