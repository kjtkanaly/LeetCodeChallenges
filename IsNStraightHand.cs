public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) {
        
        // Default
        if (hand.Length % groupSize != 0)
        {
            return false;
        }
        
        List<int> Hand = hand.ToList();
        Hand.Sort();
        
        // Debug
        for (int i = 0; i < Hand.Count; i++)
        {
            Console.Write(Hand[i] + ", ");
        }
        Console.Write("\n");
        ////////////////////////////////////////*/
        
        int TotalCards = Hand.Count;
        for (int i = 0; i < (TotalCards/groupSize); i++)
        {
            int CurrIndex = 0;
            
            for (int j = 0; j < groupSize; j++)
            {
                if (CurrIndex == -1)
                {
                    return false;
                }
                
                int CurrValue = Hand[CurrIndex];
                
                Console.WriteLine(CurrIndex + ": " + CurrValue);
            
                Hand.RemoveAt(CurrIndex);

                CurrIndex = Hand.FindIndex(x => x == CurrValue + 1);
            }
            
            Console.Write("\n");
        }
        
        if (Hand.Count == 0)
        {
            return true;
        }
        else
        {
            return false;    
        }
    }
}