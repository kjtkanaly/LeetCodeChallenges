def sortString(word):
    sortChars = sorted(word)
    sortWord = ""

    for c in sortChars:
        sortWord += c

    return sortWord

class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        sortStrs = []

        for word in strs:
            sortWord = sortString(word)
            sortStrs.append(sortWord)
            
        # Removes Duplicates
        sortStrs = list( dict.fromkeys(sortStrs) )

        Output = []
        for keyWord in sortStrs:
            keyList = []

            for word in strs:
                sortWord = sortString(word)

                if sortWord == keyWord:
                    keyList.append(word)

            Output.append(keyList)

        return Output
