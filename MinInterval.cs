public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
    
        List<int> Output = new List<int>(queries.Length);
        
        for (int i = 0; i < queries.Length; i++)
        {
            Output.Add(int.MaxValue);
        }
        
        // Debug
        Console.WriteLine("Output Length: " + Output.Count);
        
        for (int j = 0; j < Output.Count; j++)
        {
            for (int i = 0; i < intervals.Length; i++)
            {
                if (queries[j] >= intervals[i][0] && queries[j] <= intervals[i][1])
                {
                    Output[j] = Math.Min(Output[j], intervals[i][1] - intervals[i][0] + 1);
                }
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