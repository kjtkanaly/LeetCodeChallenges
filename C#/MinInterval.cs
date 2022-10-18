public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
    
        List<int> Output = new List<int>(queries.Length);
        List<int> Complete = new List<int>(queries.Length);
        int[][] Matches;

        for (int i = 0; i < queries.Length; i++)
        {
            Console.WriteLine(i);
            
            if (Complete.Contains(queries[i]) == false)
            {
                Matches = Array.FindAll(intervals, x => x[0] <= queries[i] && x[1] >= queries[i]);
            
                if (Matches.Length > 0)
                {
                    Output.Add(Matches.Select(x => x[1] - x[0] + 1).ToArray().Min());
                }
                else
                {
                    Output.Add(-1);
                }

            }
            else
            {
                Output.Add(Output[Complete.IndexOf(queries[i])]);
            }
            
            Complete.Add(queries[i]);
        }

        return Output.ToArray();
    }
}
