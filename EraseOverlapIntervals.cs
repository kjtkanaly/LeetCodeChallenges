public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
     
        List<int> Left  = new List<int>(intervals.Length);
        List<int> Right = new List<int>(intervals.Length);
        
        for (int i = 0; i < intervals.Length; i++)
        {
            Left.Add(intervals[i][0]);
            Right.Add(intervals[i][1]);
        }
        
        List<int> LeftDist  = Left.Distinct().ToList();
        List<int> RightDist = Right.Distinct().ToList();
        
        int LeftDiff = Left.Count - LeftDist.Count;
        int RightDiff = Right.Count - RightDist.Count;
        
        return Math.Max(LeftDiff, RightDiff);
        
        // Shuld Be doing.
        // Run Through each interval
        // Check how many other intervals it overlaps with
        // Remove the interval that overlaps with the most others
        // Keep running until their are no more overlapping intervals
    }
}