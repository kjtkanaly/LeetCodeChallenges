public class Solution {
    public int SingleNumber(int[] nums) {
        
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 1; i+=2)
        {
            if (nums[i + 1] != nums[i])
            {
                return nums[i];
            }
            //Console.WriteLine(nums[i]);
        }
        
        return nums[nums.Length - 1];
    }
}