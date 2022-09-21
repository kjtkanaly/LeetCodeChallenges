public class Solution {
    
    public int[]  Numbs;
    public char[] Chars;
    public List<string> Codes = new List<string>();
    
    public int NumDecodings(string s) {
        
        // Default
        if (s[0] == '0')
        {
            return 0;
        }
        
        // Number Array
        Numbs = new int[26];
        for (int i = 1; i <= 26; i++)
        {
            Numbs[i - 1] = i; 
        }
        
        // Letters Array
        Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        Split(s, "");
        
        return Codes.Count;
    }
    
    public void Split(string S, string New)   
    {                
        // Single Branch
        if (S.Length > 0)
        {            
            int SingleIndex = Array.IndexOf(Numbs, Convert.ToInt32(new string(S[0], 1)));
            
            //Console.WriteLine(S[0] + " - " + SingleIndex);
            
            if (SingleIndex != -1)
            {
                string single = New + Chars[SingleIndex];
                
                //Console.WriteLine(S);
                //Console.WriteLine("S Length: " + S.Length);
                
                if (S.Length != 0)
                {
                    Split(S[1..S.Length], single);   
                }
                
                if (S.Length == 1)
                {
                    //Console.WriteLine(single);
                    Codes.Add(single);
                }
            }
            else
            {
                return;
            }
        }
        
        
        // Double Branch
        if (S.Length > 1)
        {            
            int DoubleIndex = Array.IndexOf(Numbs, Convert.ToInt32(S[0..2]));
            
            //Console.WriteLine(S[0..2] + " - " + DoubleIndex);
            
            if (DoubleIndex != -1)
            {
                string twice = New + Chars[DoubleIndex];
                
                //Console.WriteLine(S);
                //Console.WriteLine("S Length: " + S.Length);
                
                if (S.Length > 1)
                {
                    Split(S[2..S.Length], twice);   
                }
                
                if (S.Length == 2)
                {
                    //Console.WriteLine(twice);
                    Codes.Add(twice);
                }
            }
        }

    }
}
