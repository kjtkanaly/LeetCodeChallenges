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
        
        int index = Array.FindLastIndex(nums, nums.Length - 2, x => x == 0);

        while (index != -1)
        {
            //Console.WriteLine("Zero Index: " + index);
            
            if (index == 0)
            {
                return false;
            }
            
            for (int Left = index - 1; Left > -1; Left--)
            {
                //Console.WriteLine("Distance: " + (index - Left));
                
                if (nums[Left] > (index - Left))
                {
                    break;
                }
                
                if (Left == 0)
                {
                    return false;
                }
            }
            
            index = Array.FindLastIndex(nums, index -1, x => x == 0);
        }
            
        return true;
    }
}