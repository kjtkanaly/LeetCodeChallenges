public class Solution {
    public int[][] Merge(int[][] intervals) {
        
        List<int[]> Intervals = intervals.ToList();
        List<int> Left  = new List<int>();
        List<int> Right = new List<int>();
        
        for (int i = 0; i < Intervals.Count; i++)
        {
            Left.Add(Intervals[i][0]);
            Right.Add(Intervals[i][1]);
        }
        
        Left.Sort();
        Right.Sort();
        
        /*
        // Debug
        for (int i = 0; i < Left.Count; i++)
        {
            Console.WriteLine(Left[i] + " , " + Right[i] + "\n");
        }
        */
        
        int index = 0;
        while (index < Left.Count - 1)
        {
            if (Right[index] >= Left[index + 1])
            {
                Right[index] = Right[index + 1];
                Right.RemoveAt(index + 1);
                Left.RemoveAt(index + 1);
            }
            else
            {
                index++;
            }
        }
        
        // Update Intervals List
        Intervals = new List<int[]>();
        for (int i = 0; i < Left.Count; i++)
        {
            Intervals.Add(new int[2]{Left[i], Right[i]});
        }
        
        return Intervals.ToArray();
    }
}