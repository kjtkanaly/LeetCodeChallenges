public class Solution {
    
    public IList<IList<int>> Result = new List<IList<int>>();
    
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        
        List<int> Cands = candidates.ToList();
        Cands.Sort();
        Cands.RemoveAll(x => x > target);   // <-- Because we will only be given postive ints
   
        // Default
        if (Cands.Sum() < target)
        {
            return Result;
        }
        
        
        // Debug
        for (int i = 0; i < Cands.Count; i++)
        {
            Console.Write(Cands[i] + ", ");
        }
        Console.Write("\n");
        /**/
        
        Tree(Cands, target, new List<int>());
        
        return Result;
    }
    
    public void Tree(List<int> Cands, int target, List<int> Input)
    {   
        if (Input.Sum() == target)
        {
            Result.Add(Input);
        }
        
        //for (int i = 0; i < Cands.Count; i++)
        //int i = 0;
        int PreviousValue = -1;
        int i = Cands.FindIndex(x => x <= target);
        while (i != -1)
        {
            if (Cands[i] > PreviousValue)
            {
                PreviousValue = Cands[i];
                
                // Update Input
                int[] Temp = new int[Input.Count];
                Input.CopyTo(Temp);

                List<int> InputUpdate = Temp.ToList();
                InputUpdate.Add(Cands[i]);

                // Update Cands
                Temp = new int[Cands.Count];
                Cands.CopyTo(Temp);

                List<int> CandsUpdate = Temp.ToList();
                CandsUpdate.RemoveRange(0,i+1);

                Tree(CandsUpdate, target, InputUpdate);

                //Cands.RemoveAll(x => x == Cands[i]);
                
            }
            
            i = Cands.FindIndex(i + 1, x => x <= target);
        }
    }
}