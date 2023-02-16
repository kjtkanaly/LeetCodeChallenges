class Solution:
    def reverse(self, x: int) -> int:

        ans = "0"
        mod = 1

        if x < 0:
            mod = -1
        
        x = abs(x)

        while x > 0:
            ans = ans + str(x % 10)
            x = x // 10      

        if int(ans) > pow(2, 31):
            return 0

        return int(ans) * mod