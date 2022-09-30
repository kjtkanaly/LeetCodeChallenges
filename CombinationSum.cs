public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    
    public IList<IList<int>> CombinationSum(int[] Cand, int target) {
        
        List<int> Temp = Cand.ToList();
        Temp.Sort();
        Cand = Temp.ToArray();
        
        Tree(Cand, target, new List<int>());
        
        int Left = 0;
        while (Left < Result.Count)
        {
            int Right = Left + 1;
            while (Right < Result.Count)
            {
                var ListOne = Result[Left].Except(Result[Right]).ToList();
                var ListTwo = Result[Right].Except(Result[Left]).ToList();
                
                if (ListOne.Count == 0 && ListTwo.Count == 0)
                {
                    Result.RemoveAt(Right);
                }
                else
                {
                    Right++;
                }
            }
            
            Left++;
        }

        return Result;
    }
    
    public void Tree(int[] Cand, int target, List<int> Prev)
    {        
        for (int i = 0; i < Cand.Length; i++)
        {
            int Current = target - Cand[i];
            
            List<int> Update = new List<int>(Prev.Count + 1);
            Update.AddRange(Prev);
            Update.Add(Cand[i]);
            
            Update.Sort();
            
            if (Current == 0)
            {
                Result.Add(Update);
                return;
            }       
            else if (Current > 0)
            {
                Tree(Cand, Current, Update);
            }
            else
            {
                return;
            }
        }
    }

}