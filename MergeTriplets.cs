public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        
        int[] Input = new int[3];
        
        for (int i = start; i < triplets.GetLength(0); i++)
        {
            Input[0] = Math.Max(Input[0], triplets[i][0]);
            Input[1] = Math.Max(Input[1], triplets[i][1]);
            Input[2] = Math.Max(Input[2], triplets[i][2]);
            
            /*// Debug
            for (int j = 0; j < Input.Length; j++)
            {
                Console.Write(Input[j] + ", ");
            }
            Console.Write("\n");
            //////////////////////////*/
            
            if (Input.SequenceEqual(target))public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        
        // Default
        if (triplets.GetLength(0) == 1 && triplets[0].SequenceEqual(target))
        {
            return true;
        }
        
        List<int[]> Triplets = triplets.ToList();
        
        // Find all Possible starting points
        int Index = 0;
        while (Index < Triplets.Count)
        {
            //if ((Triplets[Index][0] != target[0]) && (Triplets[Index][1] != target[1]) && (Triplets[Index][2] != target[2]))
            if ((Triplets[Index][0] > target[0]) || (Triplets[Index][1] > target[1]) || (Triplets[Index][2] > target[2]))
            {
                //Console.WriteLine(Triplets[Index][0] + ", " + Triplets[Index][1] + ", " + Triplets[Index][2]);
                Triplets.RemoveAt(Index);
            }
            else
            {
                Index++;    
            }
        }
        
        /*
        for (int j = 0; j < Triplets.Count; j++)
        {
            Console.WriteLine(Triplets[j][0] + ", " + Triplets[j][1] + ", " + Triplets[j][2]);
        }/**/
        
        
        for (int j = 0; j < Triplets.Count; j++)
        {            
            int[] Input = new int[3];
            Input[0] = Triplets[0][0];
            Input[1] = Triplets[0][1];
            Input[2] = Triplets[0][2];
            
            //Console.WriteLine(Input[0] + ", " + Input[1] + ", " + Input[2]);
            
            for (int i = 1; i < Triplets.Count; i++)
            {
                Input[0] = Math.Max(Input[0], Triplets[i][0]);
                Input[1] = Math.Max(Input[1], Triplets[i][1]);
                Input[2] = Math.Max(Input[2], Triplets[i][2]);    

                /*// Debug
                for (int k = 0; k < Input.Length; k++)
                {
                    Console.Write(Input[k] + ", ");
                }
                Console.Write("\n");
                //////////////////////////*/

                if (Input.SequenceEqual(target))
                {
                    return true;
                }

                if ((Input[0] > target[0]) || (Input[1] > target[1]) || (Input[2] > target[2]))
                {
                    Input[0] = Triplets[0][0];
                    Input[1] = Triplets[0][1];
                    Input[2] = Triplets[0][2];
                    
                    break;
                }
            }
            
            Triplets.Add(Triplets[0]);
            Triplets.RemoveAt(0);;
            
            Console.Write("\n");
        }
        
        return false;
    }
}



        
            {
                return true;
            }
            
            if ((Input[0] > target[0]) || (Input[1] > target[1]) || (Input[2] > target[2]))
            {
                Input = triplets[0];
            }
        }
        
        return false;
    }
}

/*
        // Creating our vectors
        for (int i = 0; i < triplets.GetLength(0); i++)
        {
            first[i]  = triplets[i][0];
            second[i] = triplets[i][1];
            third[i]  = triplets[i][2];
        }
*/