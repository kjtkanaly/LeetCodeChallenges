public class Solution {
    public bool CheckInclusion(string s1, string s2) {
    
		// sort s1
        
        // take a winsow of size 1 from s2
        // and sort that Window
        
        // check if the sorted window equal s1
        // if it does then reutn true
        // if not then shift the widnow down 1 index and repeat
	
        List<char> c1Right = s1.ToArray().ToList();
        List<char> c1Left = s1.ToArray().ToList();
        
        c1Right.RemoveAt(0);
		c1Left.RemoveAt(0);
        
        char firstLetter = s1[0];
        
        int start = s2.IndexOf(firstLetter, 0);
        
        //Debug
        Console.WriteLine(start);
        
        // Sliding to the right
        while (start != -1)
        {
            c1Right = s1.ToArray().ToList();
            c1Right.RemoveAt(0);
            
            // Check to the right of start
            int right = start + 1;
            while((c1Right.Count > 0) && (right < s2.Length))
            {
                if (c1Right.Contains(s2[right]))
                {
                    c1Right.Remove(s2[right]);
                }
                else
                {
                    break;
                }
                right++;
            }
            
            if (c1Right.Count == 0)
            {
                return true;
            }
            
			c1Left = s1.ToArray().ToList();
			c1Left.RemoveAt(0);
            
            // Check to the left of start
            int left = start - 1; 
            while((c1Left.Count > 0) && (c1Right.Count > 0) && (left > -1))
            {
                Console.WriteLine("C1 Left Count: " + c1Left.Count);
                
                bool RightBreakFlag = false;
                
                if (c1Right.Contains(s2[left]))
                {
                    c1Right.Remove(s2[left]);
                }
                else
                {
                    RightBreakFlag = true;
                }
                
				if (c1Left.Contains(s2[left]))
				{
					c1Left.Remove(s2[left]);
				}
                else
                {
                    if (RightBreakFlag == true)
                    {
                        break;
                    }
                }
				
                left--;
            }
            
            
            if ((c1Right.Count == 0) || (c1Left.Count == 0))
            {
                return true;
            }
            
            start = s2.IndexOf(firstLetter, start + 1);
            
            //Debug
            Console.WriteLine(start);
        }
        
        return false;
    }
}

/*
"abc"
"cccccbabbbaaaa"
"abc"
"bbbca"
"ab"
"eidbaooo"
"ab"
"eidboaoo"
*/