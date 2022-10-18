public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    
    public IList<IList<int>> Permute(int[] nums) {
        
        List<int> Nums = nums.ToList();
        
        Tree(Nums, new List<int>());
        
        return Result;
    }
    
    public void Tree(List<int> Nums, List<int> Input)
    {
        if (Nums.Count <= 0)
        {
            Result.Add(Input);
            return;
        }
        
        for (int i = 0; i < Nums.Count; i++)
        {
            int[] update = new int[Input.Count];
            
            Input.CopyTo(update);
            List<int> Update = update.ToList();
            
            Update.Add(Nums[i]);
            
            //Console.WriteLine("Update Count: " + Update.Count);
                
            Tree(Nums.Where(x => x != Nums[i]).ToList(), Update);
        }
        
    }
}