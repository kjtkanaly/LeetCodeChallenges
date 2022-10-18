public class Solution {
    public void SetZeroes(int[][] matrix) {
        
        List<List<int>> cord = new List<List<int>>();
        
        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (matrix[row][col] == 0)
                {
                    cord.Add(new List<int>(2){row, col});
                }
            }
        }
        
        // Debug
        for (int i = 0; i < cord.Count; i++)
        {          
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row][cord[i][1]] = 0;
            }
            
            for (int col = 0; col < matrix[0].Length; col++)
            {
                matrix[cord[i][0]][col] = 0;
            }
        }
    }
}