public class Solution {
    
    public List<int> One = new List<int>();
    public List<int> Two = new List<int>();
    
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        // Default
        if (prerequisites.Length == 0)
        {
            return true;
        }
        
        bool ValidSched = true;
        
        for (int i = 0; i < prerequisites.Length; i++)
        {
            int[] check = new int[2]{prerequisites[i][1],prerequisites[i][0]};
            
            //Console.WriteLine(check[0] + "," + check[1]);
            
            if (check[0] == check[1])
            {
                return false;
            }
            
            One.Add(prerequisites[i][0]);
            Two.Add(prerequisites[i][1]);
            
            
            for (int j = 0; j < prerequisites.Length; j++)
            {
                if (i != j)
                {
                    if (prerequisites[j][0] == check[0] && prerequisites[j][1] == check[1])
                    {
                        return false;
                    }   
                }
            }
        }
        
        if (Two.Except(One).ToList().Count == 0)
        {
            return false;
        }
        
        if (One.Except(Two).ToList().Count == 0)
        {
            return false;
        }
        
        for (int i = 0; i < Two.Count; i++)
        {
            //Console.WriteLine("OG PreReq: " + Two[i]);
            
            if (CheckPreReqs(Two[i], Two[i]) == false)
            {
                return false;
            }
        }
        
        return ValidSched;
    }
    
    public bool CheckPreReqs(int PreReq, int OgPreReq)
    {
        int index = One.IndexOf(PreReq);
            
        if (index != -1)
        {
            //Console.WriteLine("Next PreReq: " + Two[index]);
            
            if (Two[index] == OgPreReq)
            {
                return false;
            }
            
            return CheckPreReqs(Two[index], OgPreReq);
        }
        else
        {
            return true;
        }
    }
}