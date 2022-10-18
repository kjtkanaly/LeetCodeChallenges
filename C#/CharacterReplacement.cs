public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        // Default
        if (k == s.Length)
        {
            return s.Length;
        }
        
        int Output = k;
        
        char[] sDist = s.Distinct().ToArray();
        
        for (int i = 0; i < sDist.Length; i++)
        {            
            // Find the first distinct letter
            int index = s.IndexOf(sDist[i]);
                
            // Sliding the window to the right
            while (index != -1)
            {
                int start = index;
                int left  = start;
                int right = start;
                
                int changeCount = 0;
                
                while (right < s.Length)
                {
                    if (s[right] != sDist[i])
                    {
                        if (changeCount < k)
                        {
                            changeCount++;   
                        }
                        else
                        {
                            break;
                        }
                    }
                    right++;
                }
                
                // If change count is still less than k
                // We slide to the left now
                if (changeCount < k)
                {                    
                    while (left > -1)
                    {
                        if (s[left] != sDist[i])
                        {
                            if (changeCount < k)
                            {
                                changeCount++;   
                            }
                            else
                            {
                                break;
                            }
                        }
                        left--;
                    }   
                    
                    left++;
                }
                
                if (right - left > Output)
                {
                    Output = right - left;
                    
                    if (Output == s.Length)
                    {
                        return Output;
                    }
                }
                
                // Iterate to the next distinct letter
                index = s.IndexOf(sDist[i], index + 1);
            }
        }
        
        return Output;        
    }
}