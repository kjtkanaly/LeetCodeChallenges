public class Solution {
    public string LongestPalindromeTwo(string s) {
        
        string FlipS = FlipString(s);
        int StringSize = s.Length;
        int WindowSize = s.Length;
        
        while (WindowSize > -1)
        {
            for (int i = 0; i <= s.Length - WindowSize; i++)
            {
                //Console.WriteLine(s[i..(i+WindowSize)]);
                
                if (s[i..(i+WindowSize)] == FlipS[(StringSize - i - WindowSize)..(StringSize - i)])
                {
                    return s[i..(i+WindowSize)];
                }
            }
            
            WindowSize--;
        }
        
        return FlipString(s);
    }
    
    public string FlipString(string s)
    {
        char[] c = s.ToArray();
        Array.Reverse(c);
        return new string(c);
    }
}