public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] output = {0, 0};
        
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                }
            }
        }
        
        return null;
    }
}