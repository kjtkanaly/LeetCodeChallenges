public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        // Default
        if (intervals.Length == 0)
        {
            List<int[]> Intervals = intervals.ToList();
            Intervals.Add(new int[2]{newInterval[0], newInterval[1]});
            return Intervals.ToArray();
        }
     
        int LeftIndex = -1, RightIndex = -1;
        
        for (int i = 0; i < intervals.Length; i++)
        {
            List<int> Temp = intervals[i].ToList();
            
            if (Temp[0] <= newInterval[0] && Temp[1] >= newInterval[0])
            {
                LeftIndex = i;
                break;
            }
        }
        
        for (int i = intervals.Length - 1; i > -1; i--)
        {
            List<int> Temp = intervals[i].ToList();
            
            if (Temp[0] <= newInterval[1] && Temp[1] >= newInterval[1])
            {
                RightIndex = i;
                break;
            }
        }       
        
        Console.WriteLine("Left Index: " + LeftIndex);
        Console.WriteLine("Right Index: " + RightIndex);
        
        if (LeftIndex != -1 && RightIndex == -1)
        {
            intervals[LeftIndex][1] = newInterval[1];
        }
        
        else if (LeftIndex == -1 && RightIndex != -1)
        {
            intervals[RightIndex][0] = newInterval[0];
        }
        
        else if (LeftIndex != -1 && RightIndex != -1)
        {
            if (LeftIndex < RightIndex)
            {
                List<int[]> Intervals = intervals.ToList();
                
                int Lower  = Math.Min(intervals[LeftIndex][0], newInterval[0]);
                int Higher = Math.Max(intervals[RightIndex][1], newInterval[1]);
                
                Intervals.RemoveRange(LeftIndex, RightIndex - LeftIndex + 1);
                
                Intervals.Insert(LeftIndex, new int[2]{Lower, Higher});
                
                intervals = Intervals.ToArray();
            }
        }
        else
        {
            List<int[]> Intervals = intervals.ToList();
            
            if (intervals[0][0] < newInterval[0] && intervals[intervals.Length - 1][1] > newInterval[1])
            {
                return intervals;
            }
            else if (intervals[0][0] > newInterval[0] && intervals[intervals.Length - 1][1] < newInterval[1])
            {
                Intervals = intervals.ToList();
                Intervals.Clear();
                Intervals.Add(newInterval);
                return Intervals.ToArray();
            }
            
            // Checking if the new interval fits inside one that already exist
            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervals[i][0] < newInterval[0] && intervals[i][1] > newInterval[1])
                {
                    return intervals;
                }
                
                else if (intervals[i][0] > newInterval[0] && intervals[i][1] < newInterval[1])
                {
                    intervals[i] = newInterval;
                    return intervals;
                }
            }
            
            
            
            int index = 0;
                
            for (int i = 0; i < Intervals.Count; i++)
            {
                if (Intervals[i][0] < newInterval[0])
                {
                    index = i + 1;
                }
            }
            
            Console.WriteLine("Index: " + index + "\n");
            
            Intervals.Insert(index, new int[2]{newInterval[0], newInterval[1]});
            
            
            
            intervals = Intervals.ToArray();
        }
        
        return intervals;
    }
}