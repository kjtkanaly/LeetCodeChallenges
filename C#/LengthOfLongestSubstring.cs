public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        List<char> subString = new List<char>();  
        int finalCount = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            subString = new List<char>();
            subString.Add(s[i]);
            
            for (int j = i + 1; j < s.Length; j++)
            {
                if (!subString.Contains(s[j]))
                {
                    subString.Add(s[j]);
                }
                else
                {
                    break;
                }
            }
            
            if (subString.Count > finalCount)
            {
                finalCount = subString.Count;
            }
        }
        
        return finalCount;
    }
}