public class KthLargest {

    public List<int> Stream = new List<int>();
    public int IndexOI = -1;
    
    public KthLargest(int k, int[] nums) {
        IndexOI = k;
        
        Stream = nums.ToList();
        Stream.Sort();
    }
    
    public int Add(int val) {
        Stream.Add(val);
        Stream.Sort();
        
        return Stream[Stream.Count - IndexOI];
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */