public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        
        IList<int> Output = new List<int>();
        
        int RowMin = 0, RowMax = matrix.Length - 1;
        int ColMin = -1, ColMax = matrix[0].Length - 1;
        
        int row = RowMin;
        int col = ColMax;      
        
        int RowModifier = 1;
        int ColModifier = 1;
        
        int state = 1;  // 0 - Iterate Row, 1 - Iterate Col
        
        for (int i = 0; i < matrix[0].Length - 1; i++)
        {
            Output.Add(matrix[0][i]);
            Console.Write(matrix[0][i] + ", ");
        }
        
        while (Output.Count < matrix.Length * matrix[0].Length)
        {
            
            Console.Write(matrix[row][col] + ", ");
            Output.Add(matrix[row][col]);
            
            if ((col == ColMin || col == ColMax) && state == 1)
            {
                if (col == ColMin)
                {
                    ColModifier = 1;
                    ColMax--;
                }
                else
                {
                    ColModifier = -1;
                    ColMin++;
                }
                
                state = 0;
            }
            
            else if ((row == RowMin || row == RowMax) && state == 0)
            {
                if (row == RowMin)
                {
                    RowModifier = 1;
                    RowMax--;
                }
                else
                {
                    RowModifier = -1;
                    RowMin++;
                }
                
                state = 1;
            }
            
            
            if (state == 0)
            {
                row += RowModifier;
            }
            else
            {
                col += ColModifier;
            }
            

            
        }
        Console.Write("\n");
        
        
        for (int i = 0; i < Output.Count; i++)
        {
            Console.Write(Output[i] + ", ");
        }
        Console.Write("\n");
        
        return Output;
    }
}