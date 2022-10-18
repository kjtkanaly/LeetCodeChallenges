public class Solution {
    
    public IList<IList<string>> Result = new List<IList<string>>();
    public string Goal;
    
    public IList<IList<string>> Partition(string s) {
        
        List<string> Input = new List<string>();
        Goal = s;
        
        for (int i = 0; i < s.Length; i++)
        {
            Input.Add(s[i] + "");
        }
        
        Branch(Input);
        
        int Left = 0;
        while (Left < Result.Count)
        {
            //Console.WriteLine(Result.Count);
            
            int Right = Result.Count - 1;
            while (Right > Left)
            {                
                if (Result[Left].SequenceEqual(Result[Right]))
                {
                    Result.RemoveAt(Right);
                }
                
                Right--;
            }
            
            Left++;
        }/**/
        
        return Result;
    }
    
    public void Branch(List<string> S)
    {
        for (int i = 0; i < S.Count; i++)
        {
            if (S[i] != ReverseString(S[i]))
            {
                break;
            }
            if (i == S.Count - 1)
            {
                Result.Add(S);
            }
        }
        
        
        if (S.Count == 1)
        {
            return;
        }
        
        for (int i = 0; i < S.Count - 1; i++)
        {
            string[] update = new string[S.Count];
            S.CopyTo(update);
            
            List<string> Update = update.ToList();
            //string temp = Update[Update.Count - 2] + Update[Update.Count - 1];
            Update[Update.Count - 2 - i] = Update[Update.Count - 2 - i] + Update[Update.Count - 1 - i];
            Update.RemoveAt(Update.Count - 1 - i);
            
            Branch(Update);    
        }

    }
    
    public string ReverseString(string s)
    {
        char[] c = s.ToArray();
        Array.Reverse(c);
        return new string(c);
    }
}