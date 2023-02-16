class Solution:
    def reverseBits(self, n: int) -> int:

        b = format(n, '032b')

        # print(b)

        ans = ""

        for char in b:
            ans = char + ans

        # print(ans)

        return int(ans, 2)