public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    
    public IList<IList<int>> CombinationSum(int[] Cand, int target) {
        
        // Debug
        List<int> Test1 = new List<int>(3){1,2,3};
        List<int> Test2 = new List<int>(3){1,2,3,4}; //{4,5,6};
        
        var One = Test1.Except(Test2).ToList();
        var Two = Test2.Except(Test1).ToList();
        
        Console.WriteLine(One.Count + ", " + Two.Count);
        
        List<int> Temp = Cand.ToList();
        Temp.Sort();
        Cand = Temp.ToArray();
        
        Tree(Cand, target, new List<int>());
        
        // The probelm is in here with how I'm removing duplicates
        int Left = 0;
        while (Left < Result.Count)
        {
            Console.WriteLine(Result.Count);
            
            int Right = Result.Count - 1;
            while (Right > Left)
            {
                var ListOne = Result[Left].Except(Result[Right]).ToList();
                var ListTwo = Result[Right].Except(Result[Left]).ToList();
                
                if (ListOne.Count == 0 && ListTwo.Count == 0)
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