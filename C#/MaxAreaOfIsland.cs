public class Solution {
    
    public int IslandCount = 2;
    
    public int MaxAreaOfIsland(int[][] grid) {
        
        // Default
        if (grid.Length == 1 && grid[0].Length == 1)
        {
            if (grid[0][0] == 1)
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
                if (grid[row - 1][col - 1] == 1)
                {
                    GridPad[row,col] = 1;    
                }
                else
                {
                    GridPad[row,col] = 0;    
                }
            }
        }
        
        ///////////////////////////////////////////////////////////////
        // WorkZone

        for (int row = 1; row < GridPad.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < GridPad.GetLength(1) - 1; col++)
            {
                if (GridPad[row,col] == 1)
                {
                    FindNeighbors(GridPad, row, col);
                    
                    IslandCount++;
                }
            }
        }
        
        int MaxArea = 0;
        
        for (int IslandNumber = 2; IslandNumber < IslandCount; IslandNumber++)
        {
            int Area = 0;
            for (int row = 0; row < GridPad.GetLength(0); row++)
            {
                for (int col = 0; col < GridPad.GetLength(1); col++)
                {
                    if (GridPad[row,col] == IslandNumber)
                    {
                        Area++;
                    }
                }
            }
            
            MaxArea = Math.Max(MaxArea, Area);
        }
        
        ///////////////////////////////////////////////////////////////
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
        
        return MaxArea;
    }
    
    public void FindNeighbors(int[,] Grid, int row, int col)
    {
        Grid[row,col] = IslandCount;
        
        if (Grid[row - 1,col] == 1)
        {
            FindNeighbors(Grid, row - 1, col);
        }
        
        if (Grid[row + 1,col] == 1)
        {
            FindNeighbors(Grid, row + 1, col);
        }
        
        if (Grid[row,col - 1] == 1)
        {
            FindNeighbors(Grid, row, col - 1);
        }
        
        if (Grid[row,col + 1] == 1)
        {
            FindNeighbors(Grid, row, col + 1);
        }
        
    }
}