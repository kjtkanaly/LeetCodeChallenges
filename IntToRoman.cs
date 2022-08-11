public class Solution {
	
	public int I = 1;
    public int V = 5; 
    public int X = 10;
    public int L = 50;
    public int C = 100;
    public int D = 500;
    public int M = 1000;
    
	public string romanNum = "";
	
    public string IntToRoman(int num) {
        
		while(num > 0)
        {
            if (num >= M)
            {
                romanNum = romanNum + "M";
                num -= M;
            }
            else if (num >= D)
            {
                if (num >= 900)
                {
                    romanNum = romanNum + "CM";
                    num -= 900;   
                }
                else
                {
                    romanNum = romanNum + "D";
                    num -= D;   
                }
            }
            else if (num >= C)
            {
                if (num >= 400)
                {
                    romanNum = romanNum + "CD";
                    num -= 400;   
                }
                else
                {
                    romanNum = romanNum + "C";
                    num -= C;   
                }
            }
            else if (num >= L)
            {
                if (num >= 90)
                {
                    romanNum = romanNum + "XC";
                    num -= 90;   
                }
                else
                {
                    romanNum = romanNum + "L";
                    num -= L;   
                }
            }
            else if (num >= X)
            {
                if (num >= 40)
                {
                    romanNum = romanNum + "XL";
                    num -= 40;   
                }
                else
                {
                    romanNum = romanNum + "X";
                    num -= X;   
                }
            }
            else if (num >= V)
            {
                if (num == 9)
                {
                    romanNum = romanNum + "IX";
                    num -= 9;   
                }
                else
                {
                    romanNum = romanNum + "V";
                    num -= V;   
                }
            }
            else
            {
                if (num == 4)
                {
                    romanNum = romanNum + "IV";
                    num -= 4;   
                }
                else
                {
                    romanNum = romanNum + "I";
                    num -= I;   
                }
            }
            
        }
        
        
        return romanNum;		
    }
}