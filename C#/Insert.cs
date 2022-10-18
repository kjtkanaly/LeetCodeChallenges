public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        List<int[]> Intervals = intervals.ToList();
        int LeftIndex = -1, RightIndex = -1;
        
        // List the Left and Right Values
        List<int> Left  = new List<int>();
        List<int> Right = new List<int>();
        for (int i = 0; i < Intervals.Count; i++)
        {
            Left.Add(intervals[i][0]);   
            Right.Add(intervals[i][1]);   
        }
        
        Left.Add(newInterval[0]);
        Right.Add(newInterval[1]);
        
        Left.Sort();
        Right.Sort();
        
        // Debug
        for (int i = 0; i < Left.Count; i++)
        {
            Console.WriteLine(Left[i] + " , " + Right[i]);
        }
        Console.Write("\n");
        
        int index = 0;
        while (index < Left.Count - 1)
        {
            if (Right[index] >= Left[index+1])
            {
                Right[index] = Right[index+1];
                Left.RemoveAt(index+1);
                Right.RemoveAt(index+1);
            }
            else
            {
                index++;
            }
        }
        
        // Debug
        for (int i = 0; i < Left.Count; i++)
        {
            Console.WriteLine(Left[i] + " , " + Right[i]);
        }
        Console.Write("\n");
        
        List<int[]> Output = new List<int[]>();
        for (int i = 0; i < Left.Count; i++)
        {
            Output.Add(new int[2]{Left[i],Right[i]});
        }
        
        
        return Output.ToArray();
    }
}