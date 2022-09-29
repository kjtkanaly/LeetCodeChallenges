public class Solution {
    public int LengthOfLIS(int[] nums) {
        
        int[] DP = new int[nums.Length];
        
        for (int i = 0; i < DP.Length; i++)
        {
            DP[i] = 1;
        }
        
        for (int i = nums.Length - 2; i > -1; i--)
        {            
            List<int> Counts = new List<int>();
            int index = Array.FindIndex(nums, i + 1, x => x > nums[i]);
            
            while (index != -1)
            {
                Counts.Add(DP[index]);
                
                index = Array.FindIndex(nums, index + 1, x => x > nums[i]);
            }
            
            if (Counts.Count > 0)
            {
                DP[i] = Counts.Max() + 1;    
            }            
            
            // Debug
            Console.WriteLine("Start: " + nums[i]);
            Console.WriteLine("DP: " + DP[i]);
            Console.Write("\n");
        }
        
        return DP.Max();
    }

}