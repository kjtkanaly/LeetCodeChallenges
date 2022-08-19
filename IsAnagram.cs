public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length)
        {
            return false;
        }
        
        char[] sChar = s.ToCharArray();
        char[] tChar = t.ToCharArray();
        
        Array.Sort(sChar);
        Array.Sort(tChar);
        
        Console.WriteLine(sChar);
        Console.WriteLine(tChar);
        
        return (sChar.SequenceEqual(tChar));
    }
}