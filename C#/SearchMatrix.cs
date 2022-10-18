public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        List<int[]> bigList = matrix.ToList();
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {            
            if (Array.Exists(matrix[i], x => x == target))
            {
                return true;
            }
        }
        
        return false;
    }
}