public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        
        List<int> Left  = new List<int>(intervals.Length);
        List<int> Right = new List<int>(intervals.Length);
        int DeleteCount = 0;
        
        for (int i = 0; i < intervals.Length; i++)
        {
            if (Left.Contains(intervals[i][0]) && Right.Contains(intervals[i][1]))
            {
                DeleteCount++;
            }
            else
            {
                Left.Add(intervals[i][0]);
                Right.Add(intervals[i][1]);
            }
        }
        
        while (true)
        {
            int Index = 0;
            List<int> OverlapCount = new List<int>();
            for (int i = 0; i < Left.Count; i++)
            {
                int Count = 0;
                for (int j = 0; j < Left.Count; j++)
                {
                    if (i != j)
                    {
                        if (Left[i] < Right[j] && Right[i] > Left[j])
                        {
                            Count++;
                        }
                    }
                }

                Console.WriteLine("Overlap Count: " + Count);
                OverlapCount.Add(Count);

            }
            
            Console.Write("\n");
            
            if (OverlapCount.ToArray().Sum() == 0)
            {
                return DeleteCount;
            }

            else
            {
                //Console.Write("Beep: " + OverlapCount.IndexOf(OverlapCount.Max()) + "\n\n");
                int index = OverlapCount.IndexOf(OverlapCount.Max());    
                Right.RemoveAt(index);
                Left.RemoveAt(index);
                DeleteCount++;
            }
        }
        
        
        
        
        return 0;
        
        // Shuld Be doing.
        // Run Through each interval
        // Check how many other intervals it overlaps with
        // Remove the interval that overlaps with the most others
        // Keep running until their are no more overlapping intervals
    }
}