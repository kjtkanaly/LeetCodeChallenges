public class Solution {
    public IList<string> FindWords(char[][] board, string[] words) {
        
        IList<string> Output = new List<string>();
        
        //Console.WriteLine("# of Rows: " + board.GetLength(0));
        //Console.WriteLine("# of Cols: " + board[0].GetLength(0));
        
        // Iterate through the words
        for (int WordCount = 0; WordCount < words.Length; WordCount++)
        {
            List<int[]> Cords = searchTwoDimArray(board, words[WordCount][0]);
            Console.Write("\n");
            Console.WriteLine("Word: " + words[WordCount]);
			Console.WriteLine("Cord Length: " + Cords.Count);
            
            if (Cords.Count > 0)
            {
                for (int CordCount = 0; CordCount < Cords.Count; CordCount++)
                {
                    Console.WriteLine("Target Found: " + Cords[CordCount][0] + "," + Cords[CordCount][1]);
                
                    int CharCount = 1;
                    while (CharCount < words[WordCount].Length)
                    {
						Console.WriteLine("CharCount: " + CharCount);
                        char target = words[WordCount][CharCount];

                        // Check to the left
                        if (Cords[CordCount][1] > 0)
                        {
                            if (board[Cords[CordCount][0]][Cords[CordCount][1] - 1] == target)
                            {
                                Cords[CordCount][1] -= 1;
                                CharCount++;
                            }
                        }

                        // Check to the right
                        if (Cords[CordCount][1] < board[CordCount].GetLength(0) - 1)
                        {
                            if (board[Cords[CordCount][0]][Cords[CordCount][1] + 1] == target)
                            {
                                Cords[CordCount][1] += 1;
                                CharCount++;
                            }
                        }

                        // Check Up
                        if (Cords[CordCount][0] > 0)
                        {
                            if (board[Cords[CordCount][0] - 1][Cords[CordCount][1]] == target)
                            {
                                Cords[CordCount][0] -= 1;
                                CharCount++;
                            }
                        }

                        // Check Down
                        if (Cords[CordCount][1] < board.GetLength(0) - 1)
                        {
                            if (board[Cords[CordCount][0] + 1][Cords[CordCount][1]] == target)
                            {
                                Cords[CordCount][0] += 1;
                                CharCount++;
                            }
                        }
						Console.WriteLine(board[Cords[CordCount][0]][Cords[CordCount][1]]);
                        if (board[Cords[CordCount][0]][Cords[CordCount][1]] != target)
                        {
                            break;
                        }
                    }

                    if (CharCount == words[WordCount].Length)
                    {
                        Output.Add(words[WordCount]);
                        break;
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