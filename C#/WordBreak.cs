public class Solution {
    
    public bool WordBreak(string s, IList<string> wordDict) {
        
        string Input = "";
        
        List<string> temp = new List<string>();
        for (int i = 0; i < wordDict.Count; i++)
        {
            if (s.Contains(wordDict[i]))
            {
                temp.Add(wordDict[i]);
            }
        }
        
        wordDict = temp;
        
        Console.WriteLine(wordDict.Count);
        
        return Test(s, wordDict, Input);
    }
    
    public bool Test(string s, IList<string> wordDict, string Input = "")
    {
        if (Input == s)
        {
            return true;
        }
        
        //Console.WriteLine(s.Contains(""));
        
        for (int i = 0; i < wordDict.Count; i++)
        {
            if (s.Contains(wordDict[i]) && s.Contains(Input))
            {
                bool Check = false;
            
                if (Input.Length <= s.Length)
                {
                    Check = Test(s, wordDict, Input + wordDict[i]);
                }

                if (Check == true)
                {
                    return Check;
                }
            }
            
        }
        
        return false;
    }
}