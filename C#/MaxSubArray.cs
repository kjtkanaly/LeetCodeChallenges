public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int Current = nums[0];
        int Output = nums[0];
        
        for (int i = 1; i < nums.Length; i++)
        {
            Current = Math.Max(Current + nums[i], nums[i]);
            
            Output  = Math.Max(Output, Current);
        }
        
        return Output;
    }
}