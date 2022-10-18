public class Solution {
    public int MaxArea(int[] height) {
        
        int maxArea = 0;
        
        int i = 0;
        int j = height.Length - 1;
        
        while(i < j)
        {
            int Area = (j - i) * (Math.Min(height[i], height[j]));
            
            if (Area > maxArea)
            {
                maxArea = Area;
            }
            
            if (height[i] > height[j])
            {
                j--;
            }
            else
            {
                i++;
            }
                
        }
        
        return maxArea;
        
    }
}