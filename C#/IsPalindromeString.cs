public class Solution {
    public bool IsPalindromeString(string s) {
        
        s = s.ToLower();
        
        char[] c = s.Where(n => Char.IsLetter(n) || Char.IsNumber(n)).ToArray();
        
        return (c.SequenceEqual(c.Reverse().ToArray()));
        
    }
}
