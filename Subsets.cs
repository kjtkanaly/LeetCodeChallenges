public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {        
        IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int>());

        foreach(var num in nums)
        {
            int currentCount = result.Count;
            for(int i = 0; i < currentCount; i++)
            {
                List<int> subset = result[i].ToList();
                subset.Add(num);
                result.Add(subset);                
            }            
        }

        return result;
    }
}