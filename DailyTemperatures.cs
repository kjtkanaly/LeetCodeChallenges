public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] answer = new int[temperatures.Length];
        
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            int index = Array.FindIndex(temperatures, i+1, x => x > temperatures[i]);
            
            if (index != -1)
            {
                answer[i] = index - i;
            }
        }
        
        return answer;
    }
}