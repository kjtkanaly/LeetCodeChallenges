public class Solution {
    public bool CanJump(int[] nums) {
        
        // Default
        if (nums.Length == 1)
        {
            return true;
        }
        
        // Default II
        List<int> Nums = nums.ToList();
        if (Nums.Contains(0) == false)
        {
            return true;
        }
        
        int Start = 0;
        int End   = Array.IndexOf(nums, 0);
        
        if (Start == End)
        {
            return false;
        }
        
        
        // I think I need to flip the process. Start on the right and go to the left first?
        while (End != -1)
        {
            for (int i = Start; i < End; i++)
            {
                if (nums[i] > End - i)
                {
                    break;
                }
                if (i == End - 1)
                {
                    return false;
                }
            }
            
            Start = End + 1;
            End   = Array.IndexOf(nums, End + 2, 0);
        }
            
        return true;
    }
}