public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        // Default
        if (temperatures.Distinct().ToArray().Length == 1)
        {
            return new int[temperatures.Length];
        }
        
        List<int> temp = temperatures.ToList();
        int[] answer = new int[temp.Count];
        int index = 0;
        
        temp.Insert(0, Int32.MinValue);   
        
        int limit = temp.Count - 1;
        
        for (int i = 1; i < limit; i++)
        {
            if (temp[i] == temp[i-1] && answer[i - 2] > 0)
            {
                answer[i - 1] = answer[i - 2] - 1;
            }
            else
            {
                index = temp.FindIndex(i+1, x => x > temp[i]);
            
                if (index != -1)
                {
                    answer[i - 1] = index - i;
                }   
            }
        }
        
        return answer;
    }
}