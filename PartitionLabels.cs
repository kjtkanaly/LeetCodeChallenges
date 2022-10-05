public class Solution {
    public IList<int> PartitionLabels(string s) {
    
        IList<int> Result = new List<int>();
        
        string Unique = new String(s.Distinct().ToArray());
        
        //Console.Write(Unique + "\n");
        
        List<int> Starts = new List<int>();
        List<int> Ends   = new List<int>();
        
        for (int i = 0; i < Unique.Length; i++)
        {
            Starts.Add(s.IndexOf(Unique[i]));
            Ends.Add(s.LastIndexOf(Unique[i]));
            
            //Console.WriteLine(Starts[i] + "-" + Ends[i]);
            
        }
        
        int Left = 0;
        while (Left < Starts.Count)
        {
            int Right = Left + 1;
            
            while (Right < Starts.Count)
            {
                if ((Ends[Right] >= Starts[Left]) && (Starts[Right] <= Ends[Left]))
                {
                    Starts[Left] = Math.Min(Starts[Left], Starts[Right]);
                    Ends[Left]   = Math.Max(Ends[Left], Ends[Right]);
                    
                    Starts.RemoveAt(Right);
                    Ends.RemoveAt(Right);
                }
                else
                {
                    Right++;
                }
            }
            
            Left++;
        }
        
        for (int i = 0; i < Starts.Count; i++)
        {
            //Console.WriteLine(Starts[i] + "-" + Ends[i]);
            
            Result.Add(Ends[i] - Starts[i] + 1);
        }
        
        return Result;
    }
    
}