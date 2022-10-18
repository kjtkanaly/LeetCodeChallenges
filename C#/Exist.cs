public class Solution {
    public bool Exist(char[][] board, string word) {
        
        // Zero Padding
        char[,] Board = new char[board.Length + 2, board[0].Length + 2];
        for (int row = 1; row <= board.Length; row++)
        {
            for (int col = 1; col <= board[0].Length; col++)
            {
                Board[row,col] = board[row - 1][col - 1];
            }
        }
        //DebugPrint(Board);
        
        // Finding the Starting Points
        List<int> Rows = new List<int>();
        List<int> Cols = new List<int>();
        
        for (int row = 0; row < board.GetLength(0); row++)
        {
            int col = Array.IndexOf(board[row], word[0]);
            
            while (col != -1)
            {
                // Debug
                //Console.WriteLine(row + ", " + col);
                
                Rows.Add(row + 1);
                Cols.Add(col + 1);
                
                col = Array.IndexOf(board[row], word[0], col + 1);
            }
        }
        
        if (Rows.Count == 0)
        {
            return false;
        }

        // Follow the Paths
        bool Output = Branches(Board, Rows, Cols, word.Substring(1));
        
        return Output;
    }
    
    public bool Branches(char[,] BoardOG, List<int> Rows, List<int> Cols, string word)
    {
        Console.WriteLine("\n" + word);
        
        if (word.Length == 0)
        {
            Console.Write("Final Cord: " + (Rows[0]-1) + ", " + (Cols[0]-1) + "\n");
            return true;
        }
        
        for (int index = 0; index < Rows.Count; index++)
        {
            char[,] Board = Copy2DArray(BoardOG);
            
            Board[Rows[index], Cols[index]] = '0';
            
            for (int row = Rows[index] - 1; row <= Rows[index] + 1; row++)
            {
                for (int col = Cols[index] - 1; col <= Cols[index] + 1; col++)
                {
                    if (Board[row, col] == word[0] && (Math.Abs(row - Rows[index]) != Math.Abs(col - Cols[index])))
                    {                        
                        char[,] NewBoard = Copy2DArray(Board);
                        
                        NewBoard[row, col] = '0';

                        DebugPrint(NewBoard);
                        
                        if(Branches(NewBoard, new List<int>{row}, new List<int>{col}, word.Substring(1)))
                        {
                            Console.Write("Final Cord: " + (Rows[index]-1) + ", " + (Cols[index]-1) + "\n");

                            return true;
                        }
                    }
                }
            }

        }
        
        return false;
    }
    
    public char[,] Copy2DArray(char[,] Board)
    {
        char[,] NewBoard = new char[Board.GetLength(0), Board.GetLength(1)];
                        
        for (int i = 0; i < NewBoard.GetLength(0); i++)
        {
            for (int j = 0; j < NewBoard.GetLength(1); j++)
            {
                NewBoard[i,j] = Board[i,j];
            }
        }
        
        return NewBoard;
    }
	
	public void DebugPrint(char[,] Board)
    {
        for (int row = 0; row < Board.GetLength(0); row++)
        {
            for (int col = 0; col < Board.GetLength(1); col++)
            {
                Console.Write(Board[row,col] + ", ");
            }
            
            Console.Write("\n");
        }
    }
}