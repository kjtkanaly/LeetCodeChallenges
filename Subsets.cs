public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    public int MaxLength = 0;
    
    public IList<IList<int>> Subsets(int[] nums) 
    {   
        MaxLength = nums.Length;
        
        Tree(nums.ToList(), new List<int>());
        
        return Result.Distinct().ToList();
    }
    
    public void Tree(List<int> Nums, List<int> Input, int OmitIndex = -1)
    {
        Console.WriteLine("Index: " + OmitIndex);
        Console.WriteLine("Input Len: " + Input.Count);        
        Console.WriteLine("Nums Len: " + Nums.Count + "\n");
        
        if (OmitIndex != -1)
        {
            //Input.Add(Nums[OmitIndex]);
            //Nums.RemoveAt(OmitIndex);
        }
        
        Result.Add(Input);
          
        if (Input.Count < MaxLength)
        {
            for (int i = 0; i < Nums.Count; i++)
            {   
                List<int> NewInput = new List<int>();
                NewInput.Add(Nums[i]);
                
                NewInput.AddRange(Input);
                //NewInput.Sort();

                Tree(Nums.Where(x => x != Nums[i]).ToList(), NewInput);
            }
        }
        
        
        
    }   

}