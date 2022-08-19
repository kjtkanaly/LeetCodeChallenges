public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        List<IList<int>> Output = new List<IList<int>>();
        List<int> input;
        int j, k, sum;
        
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 2; i++) {
            
            j = i + 1;
            k = nums.Length - 1;
            
            while(j < k) {
            
                sum = nums[j] + nums[k];
                
                if (sum == -nums[i]) {
                    
                    input = new List<int>(){nums[i],nums[j],nums[k]};
                    
                    Console.WriteLine(Output.SequenceEqual(input));
                    
                    Output.Add(input);
                }
                
                if (sum < nums[i]) {
                    
                    j++;                    
                }
                else {
                    
                    k--;
                }
            }
        }
        
        Console.WriteLine(Output.Distinct().Count());
        
        //return Output;
        return new List<IList<int>>();
    }
}