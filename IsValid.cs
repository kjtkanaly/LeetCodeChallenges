public class Solution {
    public bool IsValid(string s) {
        
        // Default
        if (s.Length % 2 == 1)
        {
            return false;
        }
        
        List<char> open = new List<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                open.Add(s[i]);
            }
            else
            {   
                if (open.Count == 0)
                {
                    return false;
                }
                
                if (s[i] == ')' && open[open.Count - 1] != '(')
                {
                    return false;
                }
                else if (s[i] == ']' && open[open.Count - 1] != '[')
                {
                    return false;
                }
                else if (s[i] == '}' && open[open.Count - 1] != '{')
                {
                    return false;
                }
                else
                {
                    open.RemoveAt(open.Count - 1);
                }
            }
        }
        
        if (open.Count != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }    
    
}