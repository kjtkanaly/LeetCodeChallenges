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
            
            if (Input.SequenceEqual(target))
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