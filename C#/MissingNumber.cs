public class Solution {
    public int MissingNumber(int[] nums) {
        
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (i != nums[i])
            {
                return i;
            }
        }
        
        return nums.Length;
    }
}