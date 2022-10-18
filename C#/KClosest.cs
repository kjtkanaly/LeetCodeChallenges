public class Solution {
    
    class Cord
    {
        public double radi;
        public int[] cord;
        
        public Cord(double radiValue, int[] CordValues)
        {
            radi = radiValue;
            cord = CordValues;
        }
    }
    
    public int[][] KClosest(int[][] points, int k) {
        
        int[][] Output =  new int[k][];
        
        List<Cord> Data = new List<Cord>(points.Length);
        
        for (int i = 0; i < points.Length; i++)
        {
            Data.Add(new Cord(Math.Sqrt(Math.Pow(points[i][0], 2) + Math.Pow(points[i][1], 2)), new int[2]{points[i][0], points[i][1]}) );
        }
        
        Data = Data.OrderBy(data => data.radi).ToList();
        
        Data.RemoveRange(k, Data.Count - k);
        
        return Data.Select(x => x.cord).ToArray();
    }
}