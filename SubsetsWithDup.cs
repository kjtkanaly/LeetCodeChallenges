public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        
        List<int> Nums = nums.ToList();
        Nums.Sort();
        
        // Find Every Subset
        Tree(Nums, new List<int>());
        
        return Result;
        
    }
    
    public void Tree(List<int> Nums, List<int> Input)
    {
        if (Nums.Count >= 0)
        {
            int[] InputCopy = new int[Input.Count];
            Input.CopyTo(InputCopy);
            
            Input.Sort();
            
            if (Input.SequenceEqual(InputCopy.ToList()))
            {
                Result.Add(Input);   
            }
            else
            {
                return;       
            }
        }        
        
        int PreviousValue = int.MinValue;
        
        for (int i = 0; i < Nums.Count; i++)
        {
            if (Nums[i] > PreviousValue)
            {
                PreviousValue = Nums[i];
                
                // Update Input List
                int[] listUpdate = new int[Input.Count];

                Input.CopyTo(listUpdate);
                List<int> ListUpdate = listUpdate.ToList();

                ListUpdate.Add(Nums[i]);
                //ListUpdate.Sort();

                // Update Nums List
                int[] numsUpdate = new int[Nums.Count];
                Nums.CopyTo(numsUpdate);

                List<int> NumsUpdate = numsUpdate.ToList();
                NumsUpdate.RemoveAt(i);

                Tree(NumsUpdate, ListUpdate);
            }
            
        }
        
    }
}