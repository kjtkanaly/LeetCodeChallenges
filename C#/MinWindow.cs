public class Solution {
    public string MinWindow(string s, string t) {
        
        // Default
        if (t.Length > s.Length)
        {
            return "";
        }
        
        int WindowSize = t.Length;
        
        char[] td = t.Distinct().ToArray();
        
        int start, right;
        
        while (WindowSize <= s.Length)
        {  
            start = 0;
            right = start + WindowSize;
            
            while (right <= s.Length)
            {
                // Debug
                //Console.WriteLine(s[start..right]);
                //Console.WriteLine(new String(s[start..right].Except(t).ToArray()));
                
                for (int i = 0; i < td.Length; i++)
                {
                    //Console.WriteLine(s[start..right].ToCharArray().Count(c => c == td[i]));
                    if (s[start..right].ToCharArray().Count(c => c == td[i]) < t.ToCharArray().Count(c => c == td[i]))
                    {
                        break;
                    }
                    
                    if (i == td.Length - 1)
                    {
                        return s[start..right];    
                    }
                }

                start++;
                right++;
            }
            WindowSize++;
        }

        return "";
    }
    
}