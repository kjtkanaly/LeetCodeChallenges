public class Solution {
    public int RobTwo(int[] nums) {
        
        // Default
        if (nums.Length == 1)
        {
            return nums[0];
        }
        else if (nums.Length == 2)
        {
            return Math.Max(nums[0], nums[1]);
        }
        else if (nums.Length == 3)
        {
            return Math.Max(nums[2], Math.Max(nums[0], nums[1]));
        }
        
        int Dim_One = nums[1];
        int Dim_Two = nums[0];
        
        int CurrentOne = 0;
        
        for (int i = 2; i < nums.Length - 1; i++)
        {
            CurrentOne = Math.Max(nums[i] + Dim_Two, Dim_One);
            
            Dim_Two = Math.Max(Dim_Two, Dim_One);
            Dim_One = CurrentOne;
        }
        
        Dim_One = nums[2];
        Dim_Two = nums[1];
        
        int CurrentTwo = 0;
        
        for (int i = 3; i < nums.Length; i++)
        {
            CurrentTwo = Math.Max(nums[i] + Dim_Two, Dim_One);
            
            Dim_Two = Math.Max(Dim_Two, Dim_One);
            Dim_One = CurrentTwo;
        }
        
        return Math.Max(CurrentOne, CurrentTwo);
        
    }
}