class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:

        digit = 0

        for val in digits:
            digit *= 10
            digit += val

        digit += 1

        output = []

        while digit > 0:
            output.append(digit % 10)
            digit = digit // 10

        output.reverse()
        return output