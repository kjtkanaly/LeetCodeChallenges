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
        //Console.Write("\n");
        
        Codes = Codes.Distinct().ToList();
        
        return Codes.Count;
    }
    
    public void Split(int[] SN, string Code)
    {
        if (SN.Length == 0)
        {
            Console.WriteLine(Code);
            Codes.Add(Code);
        }

        // Single Branch
        if (SN.Length > 0)
        { 
            // Single
            //Console.WriteLine("Single: " + Match[SN[SN.Length - 1]] + Code);
            try
            {
                string single = Match[SN[SN.Length - 1]] + Code;

                if (SN.Length != 0)
                {
                    Split(SN[(0)..(SN.Length - 1)], single);   
                }
                

            }
            catch
            {

            }
        }
        
        // Double Branch
        if (SN.Length > 1)
        {     
            // Double
            //Console.WriteLine("Double: " + Match[SN[SN.Length - 2] + SN[SN.Length - 1]] + Code);
            try
            {
                string twice = Match[10 * SN[SN.Length - 2] + SN[SN.Length - 1]] + Code;

                if (SN.Length > 1)
                {
                    Split(SN[(0)..(SN.Length - 2)], twice);   
                }
                
            }
            catch
            {

            }
        }
    }
}
