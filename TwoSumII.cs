public class Solution {
    public int[] TwoSumII(int[] numbers, int target) {
        
        int i = 0, j = numbers.Length - 1;
        
        while(i < j)
        {
            int sum = numbers[i] + numbers[j];
            
            if (sum == target) {
                return new int[]{i+1,j+1};
            }
            else if (sum < target) {
                i++;
            }
            else{
                j--;
            }
        }
        
        return new int[0];
    }
}