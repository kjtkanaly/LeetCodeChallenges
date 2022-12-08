class Solution:
    def isPalindrome(self, s: str) -> bool:
        s = s.lower()

        sOne = ""
        sTwo = ""
        for c in s:
            if c.isalnum():
                sOne = sOne + c
                sTwo = c + sTwo

        return (sOne == sTwo)