class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        
        # Default
        if s == "":
            return 0

        substring = ""
        maxLen = 0

        for right in range(0, len(s)):
            while (s[right] in substring):
                substring = substring[1:]
            substring += s[right]
            maxLen = max(maxLen, len(substring))
        return maxLen