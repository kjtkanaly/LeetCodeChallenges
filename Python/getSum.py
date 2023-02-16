class Solution:
    def getSum(self, a: int, b: int) -> int:
        ans = a

        if b > 0:
            for x in range(b):
                ans += 1
        else:
            for x in range(0, b, -1):
                ans -= 1

        return ans