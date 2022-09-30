public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    public int MaxLength = 0;
    
    public IList<IList<int>> Subsets(int[] nums) 
    {   
        MaxLength = nums.Length;
        
        Tree(nums.ToList(), new List<int>());
        
        IList<IList<int>> Output = new List<IList<int>>();
        
        for (int i = 0; i < Result.Count; i++)
        {
            Output.Add(Result[i]);
            
            for (int j = i + 1; j < Result.Count; j++)
            {
                if (i != j)
                {
                    var firstNotSecond = Result[i].Except(Result[j]).ToList();
                    var secondNotFirst = Result[j].Except(Result[i]).ToList();

                    if (firstNotSecond.Count == 0 && secondNotFirst.Count == 0)
                    {
                        Output.RemoveAt(Output.Count - 1);
                        break;
                    }
                }
            }
            
        }
        
        return Output;
    }
    
    public void Tree(List<int> Nums, List<int> Input, int OmitIndex = -1)
    {
        // Debug
        Console.WriteLine("Index: " + OmitIndex);
        Console.WriteLine("Input Len: " + Input.Count);        
        Console.WriteLine("Nums Len: " + Nums.Count + "\n");
        /**/
        
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
                NewInput.Sort();

                Tree(Nums.Where(x => x != Nums[i]).ToList(), NewInput);
            }
        }
        
        
        
    }   

}