public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
        if (nums.Distinct().Count() == nums.Length)
        {
            return false;
        }
        else
        {
            return true;
        }   
    }
}