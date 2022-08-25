public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        
        List<string> sls = new List<string>();
        string str = "";
        
        for (int i = 0; i < n * 2; i++)
        {
            if (i < n)
            {
                str += "(";   
            }
            else
            {
                str += ")";
            }
        }
        sls.Add(str);
        
        char[] c = str.ToArray();
        
        
        // First Slide Left
        int start = n;
        
        while (start < str.Length - 1)
        {
            int index = start;
            
            while (index > 1)
            {
                if (c[index - 2] == ')')
                {
                    break;
                }
                
                char hold = c[index];
                
                c[index] = c[index - 1];
                c[index - 1] = hold;
                
                sls.Add(new String(c));
                
                index--;
            }
            
            start ++;
        }
        
        
        // Second Slide Right
        start = n - 1;
        
        while (start > 0)
        {
            int index = start;
            
            while (index < str.Length - 1)
            {
                if (c[index + 2] == '(')
                {
                    break;
                }
                
                char hold = c[index];
                
                c[index] = c[index + 1];
                c[index + 1] = hold;
                
                sls.Add(new String(c));
                
                index++;
            }
            
            start --;
        }
        
        
        return sls.Distinct().ToList();
    }
}