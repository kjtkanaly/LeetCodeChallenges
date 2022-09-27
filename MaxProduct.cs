public class Solution {
    public int MaxProduct(int[] nums) {
        
        if (nums.Length == 1)
        {
            return nums[0];
        }
        
        Array.Sort(nums);
        Console.WriteLine("Length: " + nums.Length + "\n");
        
        
        int sum = nums.Where(x => x == -1).ToList().Sum();
        Console.WriteLine(sum);
        
        int Output = int.MinValue;
        
        int Left  = 0;
        
        while (Left < nums.Length  && Left != -1)
        {
            int Right = nums.Length - 1;
            
            while (Left <= Right)
            {
                int Result = 1;
            
                for (int i = Left; i <= Right; i++)
                {
                    Result *= nums[i];
                }

                //Console.Write("Result: " + Result + "\n");

                Output = Math.Max(Output, Result);
                
                Right--;
            }
            
            Left++;
            //Left = Array.FindIndex(nums, Left + 1, x => x > nums[Left]);
            
            Console.Write("Left: " + Left + "\n");
        }
        
        Console.Write("\n");
        return Output;
    }
}