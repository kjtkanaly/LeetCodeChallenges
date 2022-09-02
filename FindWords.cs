public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        
        IList<string> Output = new List<string>();
        
        Console.WriteLine("# of Rows: " + board.GetLength(0));
        Console.WriteLine("# of Cols: " + board[0].GetLength(0));
        
        // Iterate through the words
        for (int i = 0; i < words.Length; i++)
        {
            List<int[]> Cords = searchTwoDimArray(board, words[i][0]);
			Console.WriteLine("Cord Length: " + Cords.Count);
            
            int j = 0;
            if (Cords.Count > 0)
            {
                for (int CordCount = 0; CordCount < Cords.Count; CordCount++)
                {
                    Console.WriteLine("Target Found: " + Cords[j][CordCount] + "," + Cords[j][1]);
                
                    int CharCount = 1;
                    while (CharCount < words[i].Length)
                    {
                        char target = words[i][CharCount];

                        // Check to the left
                        if (Cords[j][1] > 0)
                        {
                            if (board[Cords[j][CordCount]][Cords[j][1] - 1] == target)
                            {
                                Cords[j][1] -= 1;
                                CharCount++;
                            }
                        }

                        // Check to the right
                        if (Cords[j][1] < board[CordCount].GetLength(0) - 1)
                        {
                            if (board[Cords[j][CordCount]][Cords[j][1] + 1] == target)
                            {
                                Cords[j][1] += 1;
                                CharCount++;
                            }
                        }

                        // Check Up
                        if (Cords[j][CordCount] > 0)
                        {
                            if (board[Cords[j][CordCount] - 1][Cords[j][1]] == target)
                            {
                                Cords[j][CordCount] -= 1;
                                CharCount++;
                            }
                        }

                        // Check Down
                        if (Cords[j][1] < board.GetLength(0) - 1)
                        {
                            if (board[Cords[j][CordCount] + 1][Cords[j][1]] == target)
                            {
                                Cords[j][CordCount] += 1;
                                CharCount++;
                            }
                        }

                        if (board[Cords[j][CordCount]][Cords[j][1]] != target)
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
        }
        
        return Output;
    }
    
    public List<int[]> searchTwoDimArray(char[][] board, char target)
    {
        List<int[]> Output = new List<int[]>();
        
        for (int row = 0; row < board.GetLength(0); row++)
        {
            int col = Array.IndexOf(board[row], target);
            
            while (col != -1)
            {
                Output.Add(new int[]{row,col});
                
                col = Array.IndexOf(board[row], target, col + 1);
            }
        }
        
        return Output;
    }
}