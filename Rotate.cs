public class Solution {
    public void Rotate(int[][] matrix) {
        
        List<int> OneDim = new List<int>();
        
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = matrix[0].Length - 1; col > -1; col--)
            {   
                OneDim.Add(matrix[col][row]);
                
                // Debug
                Console.Write(matrix[col][row] + ", ");
            }
            
            Console.Write("\n");
        }
        Console.Write("\n");
        
        // Debug
        for (int i = 0; i < OneDim.Count; i++)
        {
            Console.Write(OneDim[i] + ", ");
        }
        Console.Write("\n\n");
        
        
        int index = 0;
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix.Length; col++)
            {
                matrix[row][col] = OneDim[index];
                index++;
            }
        }
    }
}

