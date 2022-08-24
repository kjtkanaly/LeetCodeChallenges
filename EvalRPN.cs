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
                
                t.RemoveRange(index - 2, 2);
                
                if (t[index] == validOp[0])
                {
                    t.Insert(index, (char)(numb1 + numb2) + "");
                }
                
                break;
                
                t.RemoveAt(index + 1);
                
                
            }
            else
            {
                index++;   
            }
        }
        
        // Debug
        for (int i = 0; i < t.Count; i++)
        {
            Console.WriteLine(t[i]);
        }
        
        return 0;
    }
}