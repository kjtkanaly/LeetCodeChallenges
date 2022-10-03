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
            //Console.WriteLine(Result.Count);
            
            int Right = Result.Count - 1;
            while (Right > Left)
            {                
                if (Result[Left].SequenceEqual(Result[Right]))
                {
                    Result.RemoveAt(Right);
                }
                
                Right--;
            }
            
            Left++;
        }/**/

        return Result;
    }
    
    public void Tree(int[] Cand, int target, List<int> Prev)
    {        
        for (int i = 0; i < Cand.Length; i++)
        {
            //int Current = target - Cand[i];
            
            List<int> Update = new List<int>(Prev.Count + 1);
            Update.AddRange(Prev);
            Update.Add(Cand[i]);
            
            Update.Sort();
            Update.Reverse();
            
            if (Update.Sum() == target)
            {
                Result.Add(Update);
                //return;
            }       
            else if (Update.Sum() < target)
            {
                Tree(Cand, target, Update);
            }
            else
            {
                return;
            }
        }
    }

}