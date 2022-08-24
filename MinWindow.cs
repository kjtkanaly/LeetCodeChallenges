public class Solution {
    public string MinWindow(string s, string t) {
        
        // Default
        if (t.Length > s.Length)
        {
            return "";
        }
        
        int WindowSize = t.Length;
        
        char[] td = t.Distinct().ToArray();
        
        while (WindowSize <= s.Length)
        {  
            int start = 0;
            int right = start + WindowSize;
            
            while (start <= s.Length - WindowSize)
            {
                // Debug
                //Console.WriteLine(s[start..right]);
                    
                bool flag = true;
                
                for (int i = 0; i < td.Length; i++)
                {
                    //Console.WriteLine(s[start..right].ToCharArray().Count(c => c == td[i]));
                    if (s[start..right].ToCharArray().Count(c => c == td[i]) < t.ToCharArray().Count(c => c == td[i]))
                    {
                        flag = false;
                    }
                }
                
                if (flag == true)
                {
                    return s[start..right];
                }

                start++;
                right++;
            }
            WindowSize++;
        }

        
        return "";
    }
    
}