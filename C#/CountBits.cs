public class Solution {
    public int[] CountBits(int n) {
        
        int[] Output = new int[n + 1];
        
        for (int i = 0; i <= n; i++)
        {
            string Binary = Convert.ToString(i, 2);
            
            Output[i] = Binary.Where(x => x == '1').ToArray().Length;
        }
        
        return Output;
        
    }
}