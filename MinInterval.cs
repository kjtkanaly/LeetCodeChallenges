public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
    
        List<int> Output = new List<int>(queries.Length);
        
        for (int i = 0; i < queries.Length; i++)
        {
            Output.Add(int.MaxValue);
        }
        
        // Debug
        Console.WriteLine("Output Length: " + Output.Count);
        
        int[] Left  = new int[intervals.Length];
        int[] Right = new int[intervals.Length];
        
        for (int i = 0; i < intervals.Length; i++)
        {
            Left[i] = intervals[i][0];
            Right[i] = intervals[i][1];
        }

        Array.Sort(queries);
        Array.Sort(Left, Right);
        
        // Debug
        for (int i = 0; i < intervals.Length; i++)
        {
            Console.WriteLine(Left[i] + " , " + Right[i]);
        }
        
        
        
        // Initialize
        for (int i = 0; i < intervals.Length; i++)
        {
            if (queries[0] >= intervals[i][0] && queries[0] <= intervals[i][1])
            {
                Output[0] = Math.Min(Output[0], intervals[i][1] - intervals[i][0] + 1);
            }
        }    
        
        for (int j = 1; j < Output.Count; j++)
        {
            //Console.WriteLine(j);
            
            if (queries[j] != queries[j - 1])
            {
                for (int i = 0; i < intervals.Length; i++)
                {
                    if (queries[j] >= intervals[i][0] && queries[j] <= intervals[i][1])
                    {
                        Output[j] = Math.Min(Output[j], intervals[i][1] - intervals[i][0] + 1);
                    }
                }    
            }
                
            else
            {
                Output[j] = Output[j - 1];
            }
            
        }
        
        for (int i = 0; i < Output.Count; i++)
        {
            if (Output[i] == int.MaxValue)
            {
                Output[i] = -1;
            }
        }
        
        return Output.ToArray();
    }
}