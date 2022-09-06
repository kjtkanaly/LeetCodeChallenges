public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        
        int[][] Output =  new int[k][];
        List<int[]> Points = points.ToList();
        List<double> Radi = new List<double>(points.Length);
        
        for (int i = 0; i < points.Length; i++)
        {
            Radi.Add(Math.Sqrt(Math.Pow(Points[i][0], 2) + Math.Pow(Points[i][1], 2)));
        }
        
        for (int i = 0; i < k; i++)
        {
            int MinIndex = Radi.IndexOf(Radi.Min());
            
            Output[i] = new int[2]{Points[MinIndex][0], Points[MinIndex][1]};
            
            Points.RemoveAt(MinIndex);
            Radi.RemoveAt(MinIndex);
        }
        
        return Output;
    }
}