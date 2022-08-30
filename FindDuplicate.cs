public class Solution {
    public int FindDuplicate(int[] nums) {
        
        List<int> Numbs = new List<int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (Numbs.Contains(nums[i]))
            {
                return nums[i];
            }
            
            Numbs.Add(nums[i]);
        }
        
        return 0;
    }
}