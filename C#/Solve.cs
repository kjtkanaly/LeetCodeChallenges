public class Solution {
    public void Solve(char[][] board) {
        
        if (board.Length <= 2 || board[0].Length <= 2)
        {
            return;
        }
        
        // Make a Deep copy of the board
        char[,] Copy = new char[board.Length, board[0].Length];
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[0].Length; col++)
            {
                Copy[row,col] = board[row][col];
            }
        }
        
        // Go around the boarders of the deep copy
        // and change any edge 'O' into 'S' - "safe"
        for (int row = 0; row < board.Length; row += (Copy.GetLength(0) - 1))
        {
            for (int col = 0; col < board[0].Length; col++)
            {
                if (Copy[row,col] == 'O')
                {
                    Copy[row,col] = 'S';
                }
            }
        }
        
        for (int row = 0; row < board.Length; row ++)
        {
            for (int col = 0; col < board[0].Length; col += (Copy.GetLength(1) - 1))
            {
                if (Copy[row,col] == 'O')
                {
                    Copy[row,col] = 'S';
                }
            }
        }
        
        // Go through the whole array and check if every 'O'
        // is adjacent to an 'S'. If it is then change it to an S
        bool ChangeMade = true;
        while (ChangeMade)
        {
            ChangeMade = false;
            
            for (int row = 0; row < Copy.GetLength(0); row++)
            {
                for (int col = 0; col < Copy.GetLength(1); col++)
                {
                    if (Copy[row,col] == 'O')
                    {
                        if (Copy[row - 1,col] == 'S' || Copy[row + 1,col] == 'S' ||
                            Copy[row,col - 1] == 'S' || Copy[row,col + 1] == 'S')
                        {
                            Copy[row,col] = 'S';
                            ChangeMade = true;
                        }
                    }
                }
            }
        }
        
        // Finally, Go through the whole array again and set Board Array
        // elements to 'X's
        for (int row = 0; row < Copy.GetLength(0); row++)
            {
                for (int col = 0; col < Copy.GetLength(1); col++)
                {
                    if (Copy[row,col] == 'S')
                    {
                        board[row][col] = 'O';
                    }
                    else
                    {
                        board[row][col] = 'X';
                    }
                }
        }
        

        // Debug
        for (int row = 0; row < board.Length; row++)
        {
            for (int col = 0; col < board[0].Length; col++)
            {
                //Console.Write(board[row][col] + " ");
                Console.Write(Copy[row, col] + " ");
            }
            Console.Write('\n');
        }
    }
}