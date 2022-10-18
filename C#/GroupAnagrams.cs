public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        IList<IList<string>> Output = new List<IList<string>>();
        string[] strsSort = new string[strs.Length];
        string[] strsDist;
        
        for (int i = 0; i < strs.Length; i++) {
            
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            strsSort[i] = new String(chars);
        }
        
        strsDist = strsSort.Distinct().ToArray();
        
        List<string> strList;
        
        for (int i = 0; i <strsDist.Length; i++)
        {
            strList = new List<string>();
            
            for (int j = 0; j < strs.Length; j++)
            {
                if (strsSort[j] == strsDist[i])
                {
                    strList.Add(strs[j]);
                }
            }
            
            Output.Add(strList);
        }
        
        return Output;
    }
}