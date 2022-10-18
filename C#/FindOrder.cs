public class Solution {
    
    public List<int> One = new List<int>();
    public List<int> Two = new List<int>();
    
    public int[] FindOrder(int numCourses, int[][] prerequisites) {

        // Default
        if (prerequisites.Length == 0)
        {
            for (int i = 0; i < numCourses; i++)
            {
                One.Add(i);
            }
            return One.ToArray();
        }

        bool ValidSched = true;

        for (int i = 0; i < prerequisites.Length; i++)
        {
            int[] check = new int[2]{prerequisites[i][1],prerequisites[i][0]};

            //Console.WriteLine(check[0] + "," + check[1]);

            if (check[0] == check[1])
            {
                return new int[0];
            }

            One.Add(prerequisites[i][0]);
            Two.Add(prerequisites[i][1]);


            for (int j = 0; j < prerequisites.Length; j++)
            {
                if (i != j)
                {
                    if (prerequisites[j][0] == check[0] && prerequisites[j][1] == check[1])
                    {
                        return new int[0];
                    }   
                }
            }
        }

        if (Two.Except(One).ToList().Count == 0)
        {
            return new int[0];
        }

        if (One.Except(Two).ToList().Count == 0)
        {
            return new int[0];
        }

        for (int i = 0; i < Two.Count; i++)
        {
            //Console.WriteLine("OG PreReq: " + Two[i]);

            if (CheckPreReqs(Two[i], Two[i]) == false)
            {
                return new int[0];
            }
        }
        
        Two.AddRange(One);

        return Two.Distinct().ToArray();
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