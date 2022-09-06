public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        
        IList<IList<int>> Output = new List<IList<int>>();
        
        // Default
        Output.Add(new List<int>(0));
        
        if (nums.Length > 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Output.Add(new List<int>(1){nums[i]});
            }
        }
        
        if (nums.Length > 2)
        {
            int left = 0;
            
            while (left < nums.Length - 1)
            {
                int right = left + 1;
                
                while (right < nums.Length)
                {
                    Output.Add(new List<int>(2){nums[left], nums[right]});
                    
                    right++;
                }
                
                left++;
            }
        }
        
        return Output;
    }
}