public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
		
        List<char> testList;
        char[] rowTest;
        
        // Checking rows for no repeating values
        for (int i = 0; i < 9; i++)
        {
            rowTest = board[i].Where(n => n != '.').ToArray();
            
            if ((rowTest.Length == rowTest.Distinct().Count()) == false) {
                return false;
            }
            
        }
        
        // Checking columns for no reperating values
        for (int i = 0; i < 9; i++)
        {
            testList = new List<char>();
            
            for (int j = 0; j < 9; j++)
            {
                if (board[j][i] != '.') {
                    testList.Add(board[j][i]);   
                }
            }
            
            if ((testList.Count == testList.Distinct().Count()) == false) {
                return false;
            }
            
        }
        
        // Checking 3x3 squares for repeating values
        int row = 0, col = 0;
        while (row < 9) {
            
            col = 0;
            
            while (col < 9) {
                
                testList = new List<char>();
                
                for (int i = row; i < row + 3; i++) {
            
                    for (int j = col; j < col + 3; j++) {

                        if (board[i][j] != '.') {

                           testList.Add(board[i][j]);
                        }
                    }
                }
                
                if ((testList.Count == testList.Distinct().Count()) == false) {
                    return false;
                }
                
                Console.WriteLine("Row: " + row + ", Col: " + col);
                
                col += 3;
            }
            row += 3;
        }
        
        return true;
        
    }
}
