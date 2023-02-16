class Solution:
    def hammingWeight(self, n: int) -> int:

        n2 = format(n, 'b')

        count = 0
        for char in n2:
            if char == '1':
                count += 1

        return count