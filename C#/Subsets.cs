public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    public int MaxLength = 0;
    
    public IList<IList<int>> Subsets(int[] nums) 
    {   
        MaxLength = nums.Length;
        
        Tree(nums.ToList(), new List<int>());
        
        return Result;
    }
    
    public void Tree(List<int> Nums, List<int> Input, int StartIndex = 0)
    {        
        /* // Debug
        Console.WriteLine("Index: " + OmitIndex);
        Console.WriteLine("Input Len: " + Input.Count);        
        Console.WriteLine("Nums Len: " + Nums.Count + "\n");
        /**/
        
        Result.Add(Input);
          
        if (Input.Count < MaxLength)
        {
            for (int i = StartIndex; i < Nums.Count; i++)
            {   
                List<int> NewInput = new List<int>();
                NewInput.Add(Nums[i]);
                
                NewInput.AddRange(Input);
                NewInput.Sort();

                Tree(Nums.Where(x => x != Nums[i]).ToList(), NewInput, i);
                
                //Nums = Nums.Where(x => x != Nums[i]).ToList();
            }
        }

    }   

}