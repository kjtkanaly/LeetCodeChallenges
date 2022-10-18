public class Solution {
    public int LastStoneWeight(int[] stones) {
        
        List<int> Stones = stones.ToList();
        Stones.Sort();
        
        while (Stones.Count > 1)
        {
            Stones[Stones.Count - 2] = Stones[Stones.Count - 1] - Stones[Stones.Count - 2];
            
            Stones.RemoveAt(Stones.Count - 1);
            
            Stones.Sort();

        }
        
        if (Stones.Count == 1)
        {
            return Stones[0];
        }
        else
        {
            return 0;
        }
    }
}