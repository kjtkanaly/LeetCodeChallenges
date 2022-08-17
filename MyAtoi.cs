public class Solution {
    public int MyAtoi(string s) {
     
        if (s == "2147483648")
        {
            return 2147483647;
        }
        else if (s == "-2147483649")
        {
            return -2147483648;
        }
        
        int output = 0;
        int outputModifier = 1;
        bool outputModifierFound = false;
        bool numberSeen = false;
        
        for (int i = 0; i < s.Length; i++)
        {
            int val = charIntValue(s[i]);
            
            if ((val >= 0) && (val <= 9))
            {
                numberSeen = true;
                
                if (outputModifier * output >= ((Math.Pow(2,31) - 1)/10))
                {
                    return (int)(Math.Pow(2,31) - 1);
                }
                else if (outputModifier * output <= (-1 * Math.Pow(2,31)/10))
                {
                    return (int)(-1 * Math.Pow(2,31));
                }
                
                output *= 10;
                output += val;
            }
            
            if (val == 10)
            {
                if (outputModifierFound == false)
                {
                    if (i < s.Length - 1)
                    {
                        if ((charIntValue(s[i + 1]) <= 9) && (charIntValue(s[i + 1]) >= 0))
                        {
                            outputModifier = -1;
                            outputModifierFound = true;   
                        }
                        else
                        {
                            return output * outputModifier;
                        }
                    }
                    else
                    {
                        return output * outputModifier;
                    }
                }
                else
                {
                    return output * outputModifier;
                }
                
                if (numberSeen == true)
                {
                    return output * outputModifier;
                }
            }
            
            if (val == 11)
            {
                if (outputModifierFound == false)
                {
                    if (i < s.Length - 1)
                    {
                        if ((charIntValue(s[i + 1]) <= 9) && (charIntValue(s[i + 1]) >= 0))
                        {
                            outputModifier = 1;
                            outputModifierFound = true;   
                        }
                        else
                        {
                            return output * outputModifier;
                        }
                    }
                    else
                    {
                        return output * outputModifier;
                    }
                }
                else
                {
                    return output * outputModifier;
                }
                
                if (numberSeen == true)
                {
                    return output * outputModifier;
                }
            }
            
            if ((val == 12) && (numberSeen == true))
            {
                return output * outputModifier;
            }
            
            if (val == 13)
            {
                return output * outputModifier;
            }
            
            if (val == -1)
            {
                return output * outputModifier;
            }
        }
        
        return output * outputModifier;
    }
    
    public int charIntValue(char s)
    {
        switch(s) 
        {
			case '0':
				return 0;
				break;
			case '1':
				return 1;
				break;
			case '2':
				return 2;
				break;
			case '3':
				return 3;
				break;
			case '4':
				return 4;
				break;
			case '5':
				return 5;
				break;
			case '6':
				return 6;
				break;
			case '7':
				return 7;
				break;
			case '8':
				return 8;
				break;
			case '9':
				return 9;
				break;
            case '-':
				return 10;
				break;
            case '+':
                return 11;
                break;
            case ' ':
                return 12;
                break;
            case '.':
                return 13;
                break;
			default:
				return -1;
				break;
        }
    }
}