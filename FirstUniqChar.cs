public class Solution {
    public int FirstUniqChar(string s) {
        
        if (s == "")
        {
            return -1;
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            bool flag = true;           
            
            for (int j = 0; j < s.Length; j++)
            {
                if (i != j)
                {
                    if (s[i] == s[j])
                    {
                        flag = false;
                        break;
                    }                    
                }
            }
            
            if (flag == true)
            {
                return i;
            }
        }
        
        return -1;
        
    }
}