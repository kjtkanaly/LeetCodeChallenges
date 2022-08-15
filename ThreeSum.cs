public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        IList<IList<int>> Output = new List<IList<int>>();
        bool flag;
        
        //Array.Sort(nums);
        
        // Checking for more than two
                
        for (int i = 0; i < nums.Length; i++)
        {            
            for (int j = 0; j < nums.Length; j++)
            {
                if (j != i)
                {
                    for (int k = 0; k < nums.Length; k++)
                    {
                        if ((k != j) && (k != i))
                        {
                            if (nums[i] + nums[j] + nums[k] == 0)
                            {
                                List<int> entry = new List<int>(){nums[i], nums[j], nums[k]};
                                
                                entry.Sort();
                                
                                flag = true;
                                
                                for (int m = 0; m < Output.Count; m++)
                                {
                                    if ((Output[m][0] == entry[0]) && (Output[m][1] == entry[1]) && (Output[m][2] == entry[2]))
                                    {
                                        flag = false;
                                        break;
                                    }
                                }

                                if (flag == true)
                                {
                                    Output.Add(entry); 
                                    break;
                                }
                            }
                        }
                    }   
                }
            }
        }         
        
        return Output;
    }
}