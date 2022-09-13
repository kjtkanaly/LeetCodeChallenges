public class Solution {
    public int Reverse(int x) {
        
        string s = x.ToString();
        
        char[] c = s.ToCharArray();
        Array.Reverse(c);
        s = new string(c);
        
        if (s[s.Length - 1] == '-')
        {
            s = s.Remove(s.Length - 1);
            s = "-" + s;
        }
        
        int Output;
        try
        {       
            Output = Convert.ToInt32(s);
        }
        catch
        {
            Output = 0;
        }
        
        return Output;
    }
}