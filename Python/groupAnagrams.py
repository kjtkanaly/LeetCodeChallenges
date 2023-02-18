class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        output = []
        uniqueStrs = []

        for string in strs:
            sortedList = list(string)
            sortedList.sort()
            unqStr = ''.join(sortedList)
            
            if unqStr in uniqueStrs:
                index = uniqueStrs.index(unqStr)
                output[index].append(string)
            else:
                output.append([string])
                uniqueStrs.append(unqStr)

        return output
            