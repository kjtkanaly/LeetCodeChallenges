public class Solution {
    
    public int I = 1;
    public int V = 5; 
    public int X = 10;
    public int L = 50;
    public int C = 100;
    public int D = 500;
    public int M = 1000;
    
    public int inputValue = 0;
    
    public int RomanToInt(string s) {
        
        s = string.Concat(s," ");
        
        for (int i = 0; i < s.Length - 1; i++)
        {   
            
            switch (s[i])
            {
                case 'I':
                    if ((s[i + 1] == 'V') || (s[i + 1]) == 'X')
                    {
                        inputValue -= I;   
                    }
                    else
                    {
                        inputValue += I;
                    }
                    break;
                    
                case 'V':
                    inputValue += V;
                    break;
                    
                case 'X':
                    if ((s[i + 1] == 'L') || (s[i + 1]) == 'C')
                    {
                        inputValue -= X;   
                    }
                    else
                    {
                        inputValue += X;
                    }
                    break;
                    
                case 'L':
                    inputValue += L;
                    break;
                    
                case 'C':
                    if ((s[i + 1] == 'D') || (s[i + 1]) == 'M')
                    {
                        inputValue -= C;   
                    }
                    else
                    {
                        inputValue += C;
                    }
                    break;
                    
                case 'D':
                    inputValue += D;
                    break;
                    
                case 'M':
                    inputValue += M;
                    break;
                    
                default:
                    Console.WriteLine("Invalid Input");
                    return 0;
                    break;
            }
        }
        
        return inputValue;
    }
}