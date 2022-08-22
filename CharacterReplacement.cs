public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        int Output = k;
        
        char max = s.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        
        int maxIndex = s.IndexOf(max, 0);   
        
        while (maxIndex != -1)
        {
            Console.WriteLine("Starting Index: " + maxIndex);
            
            int count = 0, index = maxIndex;
            
            while ((count < k) && (index < s.Length))
            {
                if (s[index] != max)
                {
                    count++;
                }
                index++;
                Console.WriteLine("   " + index);
            }
            
            while ((index < s.Length) && (s[index] == max))
            {
                Console.WriteLine("   " + index);
                index++;
            }
            
            if (index - maxIndex > Output)
            {
                Output = index - maxIndex + 1;
            }
            
            //Console.WriteLine(index - maxIndex);
            
            if (Output == s.Length)
            {
                return Output;
            }
            
            maxIndex = s.IndexOf(max, maxIndex + 1);   
        }
        
        return Output;
        
    }
}