class Solution:
    def isValid(self, s: str) -> bool:

        while (len(s) > 0):
            if(s.find("()") != -1):
                s = s.replace("()","")

            elif(s.find("{}") != -1):
                s = s.replace("{}","")

            elif(s.find("[]") != -1):
                s = s.replace("[]","")
            else:
                break

        return (s == "")
        