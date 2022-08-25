public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        
        int[] answer = new int[temperatures.Length];
        
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            int[] temp = temperatures[(i + 1)..(temperatures.Length)].Where(x => x > temperatures[i]).ToArray();
            
            if (temp.Length > 0)
            {
                answer[i] = Array.IndexOf(temperatures, temp[0], i + 1) - i;   
            }
        }
        
        return answer;
    }
}