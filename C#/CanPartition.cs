public class Solution {
    public bool CanPartition(int[] nums) {
        
        // Default
        if (nums.Length == 2)
        {
            if (nums[0] == nums[1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        int Sum = nums.Sum();
        
        // Default II
        if (Sum % 2 != 0)
        {
            return false;
        }
        
        List<int> SubSums = new List<int>();
            
        for (int Index = nums.Length - 1; Index > -1; Index--)
        {            
            int[] Previous = new int[SubSums.Count];
            SubSums.CopyTo(Previous);
            
            for (int i = 0; i < Previous.Length; i++)
            {
                if (SubSums.Contains(Previous[i] + nums[Index]) == false)
                {
                    SubSums.Add(Previous[i] + nums[Index]);    
                }
            }
            
            SubSums.Add(nums[Index]);
            
            // Debug 
            /*
            Console.WriteLine("Start: " + nums[Index]);
            Console.Write("SubSums: ");
            for (int i = 0; i < SubSums.Count; i++)
            {
                Console.Write(SubSums[i] + ", ");
            }
            Console.Write("\n\n");
            /**/
            
            
            for (int i = 0; i < SubSums.Count; i++)
            {
                if (Sum - SubSums[i] == SubSums[i])
                {
                    return true;
                }
            }
            
            
            
        }
            
        return false;
    }
}