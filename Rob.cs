public class Solution {
    public int Rob(int[] nums) {
        
        int previous = 0;
        int total = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            int temp = total;
            
            total += Math.Max(nums[i], nums[i - 1] + nums[i + 1]);
            
            previous = temp;
        }
        
        return total;
    }
}