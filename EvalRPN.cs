public class Solution {
    public int EvalRPN(string[] tokens) {
        
        List<string> t = tokens.ToList();
        
        List<string> validOp = new List<string>();
        validOp.Add("+");
        validOp.Add("-");
        validOp.Add("*");
        validOp.Add("/");
        
        int index = 0;
        
        while (index < t.Count)
        {
            if (validOp.Contains(t[index]))
            {                
                var numb1 = Convert.ToInt32(t[index - 2]);
                var numb2 = Convert.ToInt32(t[index - 1]);
                
                if (t[index] == validOp[0])
                {
                    t.Insert(index - 2, (numb1 + numb2) + "");
                    t.RemoveRange(index - 1, 3);
                }
                
                else if (t[index] == validOp[1])
                {
                    t.Insert(index - 2, (numb1 - numb2) + "");
                    t.RemoveRange(index - 1, 3);
                }
                
                else if (t[index] == validOp[2])
                {
                    t.Insert(index - 2, (numb1 * numb2) + "");
                    t.RemoveRange(index - 1, 3);
                }
                
                else if (t[index] == validOp[3])
                {
                    t.Insert(index - 2, (numb1 / numb2) + "");
                    t.RemoveRange(index - 1, 3);
                } 
                
                //break;
                index = 0;
            }
            
            else
            {
                index++;   
            }            
        }
        
        return Convert.ToInt32(t[0]);
    }
}