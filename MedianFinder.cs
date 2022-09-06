public class MedianFinder {

    public List<int> Data;
    
    public MedianFinder() {
        Data = new List<int>();
    }
    
    public void AddNum(int num) {
        int index = Data.FindIndex(x => x > num);
        
        if (index != -1)
        {
            Data.Insert(index, num);   
        }
        else
        {
            Data.Add(num);
        }
    }
    
    public double FindMedian() {
        
        // Even
        if (Data.Count % 2 == 0)
        {
            return ((double)Data[Data.Count/2] + (double)Data[Data.Count/2 - 1])/2;
        }
        // Odd
        else
        {
            return Data[Data.Count/2];
        }
        
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */