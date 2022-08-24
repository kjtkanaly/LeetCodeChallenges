public class Solution {
    public bool CheckInclusion(string s1, string s2) {
    
        // sort s1
        
        // take a winsow of size 1 from s2
        // and sort that Window
        
        // check if the sorted window equal s1
        // if it does then reutn true
        // if not then shift the widnow down 1 index and repeat
        
        int windowSize = s1.Length;
        int start = 0;
        int right = start + windowSize;
        
        s1 = SortString(s1);
        
        string s2Window;
        
        while (start <= s2.Length - windowSize)
        {
            s2Window = s2[start..right];
            
            s2Window = SortString(s2Window);
            
            if (s1 == s2Window)
            {
                return true;
            }
            
            start++;
            right++;
        }
        
        return false;
    }
    
    public string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}
