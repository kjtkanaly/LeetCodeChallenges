public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        float k = 1;
        double dayCount = 0;
        
        while (true)
        {
            dayCount = 0;
            
            //Console.WriteLine("K value: " + k);
            
            for (int i = 0; i < piles.Length; i++)
            {
                //Console.WriteLine( Math.Ceiling((decimal)(piles[i] / k)) );
                dayCount += (double)Math.Ceiling((decimal)(piles[i] / k));
                
                if (dayCount > h)
                {
                    break;
                }
            }
            
            //Console.WriteLine("Day Count: " + dayCount);
            //Console.Write("\n");
            
            if (dayCount > h)
            {
                k++;
            }
            else
            {
                return ((int)k);
            }
            
        }
        
        return 0;
    }
}