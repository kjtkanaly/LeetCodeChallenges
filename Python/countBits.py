class Solution:
    def countBits(self, n: int) -> List[int]:

        ans = []

        for x in range(n + 1):
            b = format(x, 'b')
            ans.append(b.count('1'))
        
        return ans