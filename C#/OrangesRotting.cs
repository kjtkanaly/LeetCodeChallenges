public class Solution {
    public int OrangesRotting(int[][] grid) {
        
        // Making Deep Copy
        int[,] Current = new int[grid.Length + 2, grid[0].Length + 2];
        int[,] Update  = new int[grid.Length + 2, grid[0].Length + 2];
        
        for (int row = 1; row < grid.Length + 1; row++)
        {
            for (int col = 1; col < grid[0].Length + 1; col++)
            {
                Update[row,col]  = grid[row - 1][col - 1];
            }
        }
        
        // Spread the 'Rotting' Across the grid
        // Count the iterations in the while loop
        bool ChangeMade = true;
        int  ChangeCount = 0;
        
        while (ChangeMade)
        {
            ChangeMade = false;
            ChangeCount++;
            
            // Updating Current grid
            for (int row = 0; row < Current.GetLength(0); row++)
            {
                for (int col = 0; col < Current.GetLength(1); col++)
                {
                    Current[row,col]  = Update[row,col];
                    
                    // Debug
                    Console.Write(Current[row,col] + " ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");

            for (int row = 1; row < Current.GetLength(0) - 1; row++)
            {
                for (int col = 1; col < Current.GetLength(1) - 1; col++)
                {
                    if (Current[row,col] == 2)
                    {
                        if (Current[row - 1,col] == 1)
                        {
                            Update[row - 1,col] = 2;
                            ChangeMade = true;
                        }		

                        if (Current[row + 1,col] == 1)
                        {
                            Update[row + 1,col] = 2;
                            ChangeMade = true;
                        }

                        if (Current[row,col - 1] == 1)
                        {
                            Update[row,col - 1] = 2;
                            ChangeMade = true;
                        }

                        if (Current[row,col + 1] == 1)
                        {
                            Update[row,col + 1] = 2;
                            ChangeMade = true;
                        }
                    }
                }
            }
        }
        
        // Once No more change is made then go through
        // and check for any remaining fresh oranges
        for (int row = 1; row < Current.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < Current.GetLength(1) - 1; col++)
            {
                if (Current[row,col] == 1)
                {
                    return -1;
                }
            }
        }
        
        return ChangeCount - 1;
        

        
        // If no fresh oranges reamin return the while loop
        // count. If fresh ones reamin then return -1
        
    }
}