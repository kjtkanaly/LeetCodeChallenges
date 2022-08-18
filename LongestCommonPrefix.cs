public class Solution {
    
    public string LongestCommonPrefix(string[] strs) {
     
        int loopLength = strs[0].Length;
        
        for (int i = 1; i < strs.Length; i++)
        {
            loopLength = Math.Min(loopLength, strs[i].Length);
        }
        
        string Output = "";
        
        for (int i = 0; i < loopLength; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[0][i] != strs[j][i])
                {
                    return Output;
                }
            }
            
            Output += strs[0][i];
        }   
        return Output;
    }
}