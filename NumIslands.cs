public class Solution {
    public int NumIslands(char[][] grid) {

        // Default
        if (grid.Length == 1)
        {
            if (grid[0][0] == '1')
            {
                return 1;   
            }
            else
            {
                return 0;
            }
        }
            
        
        // Zero Pad out grid's border
        int[,] GridPad = new int[grid.Length + 2, grid[0].Length + 2]; 
        for (int row = 1; row < GridPad.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < GridPad.GetLength(1) - 1; col++)
            {
                if (grid[row - 1][col - 1] == '1')
                {
                    GridPad[row,col] = 1;    
                }
                else
                {
                    GridPad[row,col] = 0;    
                }
            }
        }

        int IslandCount = 1;
        
        for (int row = 1; row < GridPad.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < GridPad.GetLength(1) - 1; col++)
            {
                if (GridPad[row,col] == 1)
                {
                    // Check the neighboring ones
                    if (GridPad[row + 1,col] == IslandCount || GridPad[row - 1,col] == IslandCount || 
                        GridPad[row,col - 1]  == IslandCount || GridPad[row,col + 1] == IslandCount)
                    {
                        GridPad[row,col] = IslandCount;
                    }
                    
                    if (GridPad[row + 1,col] == 1 || GridPad[row - 1,col] == 1 || 
                        GridPad[row,col - 1]  == 1 || GridPad[row,col + 1] == 1)
                    {
                        GridPad[row,col] = IslandCount;
                    }
                    
                    else
                    {
                        IslandCount++;
                    }
                }
            }
        }
        
        // Debug
        for (int row = 0; row < GridPad.GetLength(0); row++)
        {
            for (int col = 0; col < GridPad.GetLength(1); col++)
            {
                Console.Write(GridPad[row,col] + ", ");
            }
            Console.Write("\n");
        }
        
        Console.Write("\n");
        
        return IslandCount;
    }
}