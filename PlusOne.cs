public class Solution {
    public int[] PlusOne(int[] digits) {
        
        List<int> Digits = digits.ToList();
        
        Digits[Digits.Count - 1]++;
        
        
        if (Digits[Digits.Count - 1] == 10)
        {
            int Index = Digits.Count - 1;
            while (Digits[Index] == 10 && Index > 0)
            {
                Digits[Index] = 0;
                Digits[Index - 1] += 1;
                Index--;
            }
            
            if (Digits[0] == 10)
            {
                Digits[0] = 0;
                Digits.Insert(0, 1);
            }
        }
        
        return Digits.ToArray();
    }
}