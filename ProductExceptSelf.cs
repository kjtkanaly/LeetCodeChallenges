public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int totalProduct = computeTotalArrayValue(nums);
        int[] output = new int[nums.Length];
        List<int> temp = new List<int>();
            
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0) {
                
                output[i] = totalProduct / nums[i];
            }
            else {
                
                temp = nums.ToList();
                temp.RemoveAt(i);
                output[i] = computeTotalArrayValue(temp.ToArray());
            }
        }
        
        return output;
        
    }
    
    public int computeTotalArrayValue(int[] array){
        
        int total = 1;
        
        for (int i = 0; i < array.Length; i++) {
            total *= array[i];
        }
        
        return total;
    }
}