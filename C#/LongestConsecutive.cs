public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        // Default Case
        if (nums.Length == 0)
        {
            return 0;
        }
        
        nums = nums.Distinct().ToArray();
        
        Array.Sort(nums);
        
        int Count = 1;
        List<int> Lengths = new List<int>();
        
        Console.WriteLine(nums[0]);
        
        for(int i = 1; i < nums.Length; i++) {
            
            if ((nums[i] - nums[i - 1] != 1)) {
                Lengths.Add(Count);
                Count = 0;
            }
            
            Count++;
        }
        Lengths.Add(Count);
        
        return Lengths.Max();
    }
}