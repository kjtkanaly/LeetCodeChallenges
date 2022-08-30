public class LRUCache {

    public List<int> Keys = new List<int>();
    public List<int> Data = new List<int>();

    public LRUCache(int capacity) {
        Data = Enumerable.Repeat(-1, capacity).ToList();
        Keys = Enumerable.Repeat(-1, capacity).ToList();
        
        Data.Capacity = capacity;
        Keys.Capacity = capacity;
    }
    
    public int Get(int key) {
        
        int i = Keys.IndexOf(key);
        
        if (i != -1)
        {
            Keys.Insert(0, key);
            Data.Insert(0, Data[i]);
            
            Data.RemoveAt(i + 1);
            Keys.RemoveAt(i + 1);

            return Data[0];   
        }
        else
        {
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        
        int i = Keys.IndexOf(key);
        
        if (i != -1)
        {
            Keys.Insert(0, key);
            Data.Insert(0, value);

            Data.RemoveAt(i + 1);
            Keys.RemoveAt(i + 1);   
        }
        
        else
        {
            Keys.Insert(0, key);
            Data.Insert(0, value);
            
            Data.RemoveAt(Data.Count - 1);
            Keys.RemoveAt(Keys.Count - 1);      
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */