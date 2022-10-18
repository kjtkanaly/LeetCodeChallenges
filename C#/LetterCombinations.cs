public class Solution {
    
    public IList<string> Output = new List<string>();
    public Dictionary<string, string> Values = new Dictionary<string, string>();
    
    public IList<string> LetterCombinations(string digits) {
        
        // Default
        if (digits == "")
        {
            return Output;
        }
        
        string[] alpha = new string[8]{"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
        
        for (int i = 2; i < 10; i++)
        {
            Values.Add(i + "", alpha[i-2]);
        }
        
        Branch(digits, "");
        
        return Output;
    }
    
    public void Branch(string digits, string Input)
    {
        if (digits == "")
        {
            Output.Add(Input);
            return;
        }
        
        string PossibleLetters = Values[digits[0] + ""];
        
        for (int i = 0; i < PossibleLetters.Length; i++)
        {
            string Update = Input + PossibleLetters[i];
            
            Branch(digits.Substring(1), Update);
        }
    }
    
}