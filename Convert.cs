public class Solution {
    public string Convert(string s, int numRows) {
        
        // Default Case
        if (numRows == 1)
        {
            return s;
        }
        
        string output = "";
        string[,] zig = new string[numRows, s.Length];
        int row = 0, col = 0;
        
        // Int zig
        for (row = 0; row < numRows; row++)
        {
            for (col = 0; col < s.Length; col++)
            {
                zig[row,col] = "";
            }
        }
        
        row = 0;
        col = 0;
        
        for (int i = 0; i < s.Length; i++)
        {
            if(col % (numRows - 1) == 0)
            {                
                zig[row, col] = "" + s[i];
                row++;  
                
                if (row == numRows)
                {
                    row = 0;
                    col++;
                }
            }
            else 
            {                
                zig[numRows - (col % (numRows - 1)) - 1, col] = "" + s[i];
                col++;
            }
        }
        
        int Count = 0;
        for (row = 0; row < numRows; row++)
        {
            for (col = 0; col < s.Length; col++)
            {
                if (zig[row,col] != "")
                {
                    output += zig[row,col];
                    Count++;
                    
                    if (Count == s.Length)
                    {
                        return output;
                    }
                }
            }
            
        }
        
        return output;
    }
}