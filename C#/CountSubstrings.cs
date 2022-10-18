public class Solution {
    public int CountSubstrings(string s) {
        
        string Flip = FlipString(s);
        int WindowSize = 1;
        int Count = 0;
        
        while (WindowSize <= s.Length)
        {
            for (int i = 0; i <= s.Length - WindowSize; i++)
            {
                //Console.WriteLine(s[(i)..(i + WindowSize)]);
                //Console.WriteLine(Flip[(Flip.Length - i - WindowSize)..(Flip.Length - i)]);
                //Console.WriteLine("\n");
                
                if (s[(i)..(i + WindowSize)] == Flip[(Flip.Length - i - WindowSize)..(Flip.Length - i)])
                {
                    Count++;
                }
            }
            
            WindowSize++;
        }
        
        return Count;
    }
    
    public string FlipString(string s)
    {
        char[] c = s.ToArray();
        Array.Reverse(c);
        return new string(c);
    }
}