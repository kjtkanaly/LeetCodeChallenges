public class Solution {
    public int MaxProduct(int[] nums) {
        
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        int Output = int.MinValue;
        
        int Left  = 0;
        
        while (Left < nums.Length)
        {
            int Right = nums.Length - 1;
            
            if (nums[Left] != -1 && nums[Left] != 1)
            {
                while (Left <= Right)
                {
                    int Result = 1;

                    for (int i = Left; i <= Right; i++)
                    {
                        Result *= nums[i];
                    }

                    Console.Write("Result: " + Result + "\n");

                    Output = Math.Max(Output, Result);

                    Right--;
                }
            }
            
            
            
            Left++;
        }
        
        Console.Write("\n");
        return Output;
    }
}