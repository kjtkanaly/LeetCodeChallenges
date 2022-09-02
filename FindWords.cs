public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        
        IList<string> Output = new List<string>();
        
        Console.WriteLine("# of Rows: " + board.GetLength(0));
        Console.WriteLine("# of Cols: " + board[0].GetLength(0));
        
        // Iterate through the words
        for (int i = 0; i < words.Length; i++)
        {
            int[] Cord = searchTwoDimArray(board, words[i][0]);
            
            if (Cord[0] != -1 && Cord[1] != -1)
            {
                Console.WriteLine("Target Found: " + Cord[0] + "," + Cord[1]);
                
                int CharCount = 1;
                while (CharCount < words[i].Length)
                {
                    char target = words[i][CharCount];
                    
                    // Check to the left
                    if (Cord[1] > 0)
                    {
                        if (board[Cord[0]][Cord[1] - 1] == target)
                        {
                            Cord[1] -= 1;
                            CharCount++;
                        }
                    }
                    
                    // Check to the right
                    if (Cord[1] < board[0].GetLength(0) - 1)
                    {
                        if (board[Cord[0]][Cord[1] + 1] == target)
                        {
                            Cord[1] += 1;
                            CharCount++;
                        }
                    }
                    
                    // Check Up
                    if (Cord[0] > 0)
                    {
                        if (board[Cord[0] - 1][Cord[1]] == target)
                        {
                            Cord[0] -= 1;
                            CharCount++;
                        }
                    }
                    
                    // Check Down
                    if (Cord[1] < board.GetLength(0) - 1)
                    {
                        if (board[Cord[0] + 1][Cord[1]] == target)
                        {
                            Cord[0] += 1;
                            CharCount++;
                        }
                    }
                    
                    if (board[Cord[0]][Cord[1]] != target)
                    {
                        break;
                    }
                }
                
                if (CharCount == words[i].Length)
                {
                    Output.Add(words[i]);
                }
            }
        }
        
        return Output;
    }
    
    public int[] searchTwoDimArray(char[][] board, char target)
    {
        int row = -1, col = -1;
        
        for (int i = 0; i < board.GetLength(0); i++)
        {
            int index = Array.IndexOf(board[i], target);
            
            if (index != -1)
            {
                row = i;
                col = index;
                break;
            }
        }
        
        return new int[]{row,col};
    }
}