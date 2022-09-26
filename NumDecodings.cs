public class Solution {

    public Dictionary<int, char> Match = new Dictionary<int, char>();
    public List<string> Codes = new List<string>();
    
    public int NumDecodings(string s) {
        
        // Default
        if (s[0] == '0')
        {
            return 0;
        }
        
        // Convert s to int array
        int[] SN = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            SN[i] = Int32.Parse(s[i] + "");
        }
        
        // Letters Array
        char[] Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        // Populate the dictionary
        for (int i = 1; i <= 26; i++)
        {
            Match.Add(i, Chars[i - 1]); 
        }
        
        Split(SN, "");
        
        return Codes.Count;
    }
    
    public void Split(int[] SN, string New)   
    {                
        // Single Branch
        if (SN.Length > 0)
        {  
            try
            {
                string single = New + Match[SN[0]];
                
                if (SN.Length != 0)
                {
                    Split(SN[1..SN.Length], single);   
                }
                
                if (SN.Length == 1)
                {
                    //Console.WriteLine(single);
                    Codes.Add(single);
                }
            }
            catch
            {
                Console.WriteLine("BeeP");
                return;
            }
        }
        
        // Double Branch
        if (SN.Length > 1)
        {              
            try
            {
                string twice = New + Match[10 * SN[0] + SN[1]];
                
                if (SN.Length > 1)
                {
                    Split(SN[2..SN.Length], twice);   
                }
                
                if (SN.Length == 2)
                {
                    //Console.WriteLine(twice);
                    Codes.Add(twice);
                }
            }
            catch
            {
                
            }
        }

    }
}
