public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        
        int[] Output = new int[nums.Length - k + 1];
        
        int start = 0;
        int right = start + k;
        
        while (right <= nums.Length)
        {
            // Debug
            //Console.WriteLine(nums[start..right].Max());
            
            Output[start] = nums[start..right].Max();
                              
            start++;
            right++;
        }
        
        return Output;
    }
}