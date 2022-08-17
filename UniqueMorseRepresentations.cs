public class Solution {
    
    public string[] morseCode = new string[] {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
    
    public char[] letters = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    
    public int UniqueMorseRepresentations(string[] words) {
        
        string[] uniqueCodes = new string[words.Length];
        
        for (int i = 0; i < words.Length; i++)
        {
            string s = words[i];
            string newCode = "";
            
            for (int j = 0; j < s.Length; j++)
            {
                int index = Array.IndexOf(letters, s[j]);
                
                uniqueCodes[i] = uniqueCodes[i] + morseCode[index];
            }
            
        }
        
        return uniqueCodes.Distinct().Count();
    }
}