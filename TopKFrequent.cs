public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        List<int> Output = new List<int>();
        int[] numsDist = nums.Distinct().ToArray();
        int[] distCounts = new int[numsDist.Length];
        
        for (int i = 0; i < numsDist.Length; i++)
        {
            distCounts[i] = nums.Count(n => n ==numsDist[i]);
        }
        
        while (Output.Count < k){
            
            int index = Array.IndexOf(distCounts, distCounts.Max());
            Output.Add(numsDist[index]);
            
            numsDist[index] = -1;
            distCounts[index] = -1;
        }
        
        return Output.ToArray();
        
    }
}