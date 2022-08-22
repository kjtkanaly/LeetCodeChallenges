public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        IList<IList<int>> Output = new List<IList<int>>();
        int[] input = new int[3];
        int i, j, k, sum;
        
        Array.Sort(nums);
        
        i = 0;
        while(i < nums.Length - 2) {
            
            j = i + 1;
            k = nums.Length - 1;
            
            while(j < k) {
            
                sum = nums[j] + nums[k];
                
                if (sum == -nums[i]) {
                    
                    input = new int[3]{nums[i],nums[j],nums[k]};
                    
                    Output.Add(input);
                    
                    while ((j < k) && (nums[j] == input[1]))
                    {
                        j++;
                    }
                    
                    while ((j < k) && (nums[k] == input[2]))
                    {
                        k--;
                    }
                }
                else if (sum < -nums[i]) {
                    
                    j++;                    
                }
                else {
                    
                    k--;
                }
            }
            
            int currentNumber = nums[i];
            while((i < nums.Length) && (nums[i] == currentNumber))
            {
                i++;
            }
        }
        
        return Output;
    }
}