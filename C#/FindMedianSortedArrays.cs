public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        double    median = 0;
        List<int> comboList = new List<int>();
        
        // Create a single array
        for (int i = 0; i < nums1.Length; i++)
        {
            comboList.Add(nums1[i]);
        }
        
        for (int i = 0; i < nums2.Length; i++)
        {
            comboList.Add(nums2[i]);
        }
        
        comboList.Sort();
        
        
        int start = 0, end = comboList.Count - 1;
        
        while(start < end)
        {
            Console.WriteLine(start + " " + end);
            
            start += 1;
            end   -= 1;
        }
        
        if (start == end)
        {
            median = comboList[start];
        }
        else
        {
            median = (comboList[start] + comboList[end]) / 2.0;
        }
        

        return median;
        
    }
}
