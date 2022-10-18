public class Solution {
    
    public int Jump(int[] nums) {
        
        int JumpCount = 0;
        
        int Index = nums.Length - 1;
        while (Index > 0)
        {
            for (int Left = 0; Left < Index; Left++)
            {
                if (nums[Left] >= Index - Left)
                {
                    Index = Left;
                    JumpCount++;
                    break;
                }
            }
        }
        
        return JumpCount;
    }
}