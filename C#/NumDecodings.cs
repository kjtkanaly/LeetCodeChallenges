public class Solution {
    
    public int NumDecodings(string s) {
        
        if (s[0] == '0') {
            return 0;
        }
        
        int n = s.Length;
        
        int[] dp = new int[n + 1];
        dp[0] = 1;
        dp[1] = 1;
        
        for (int i = 2; i <= n; i++) {
            
            int ones = Int32.Parse(s.Substring(i - 1, 1));
            if (ones >= 1 && ones <= 9) {
                dp[i] += dp[i - 1];
            }
            
            int tens = Int32.Parse(s.Substring(i - 2, 2));
            if (tens >= 10 && tens <= 26) {
                dp[i] += dp[i - 2];
            }
        }
        
        return dp[n];
    }
    
    
}
