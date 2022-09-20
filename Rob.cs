public class Solution {
    public int Rob(int[] nums) {
        
        // Default
        if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        
        int Dim_One = nums[1];
        int Dim_Two = nums[0];
        
        int current = 0;
        
        for (int i = 2; i < nums.Length; i++)
        {
            current = Math.Max(nums[i] + Dim_Two, Dim_One);
            
            Dim_Two = Math.Max(Dim_Two, Dim_One);
            Dim_One = current;
        }
        
        return current;
    }
}