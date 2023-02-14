class Solution:
    def isHappy(self, n: int) -> bool:

        test = n
        prev = []

        while True:

            digits = []

            while test > 0:
                digits.append(test % 10)

                test = test // 10

            test = 0

            for val in digits:
                test += pow(val, 2)

            if test in prev:
                return False

            if test == 1:
                return True

            prev.append(test)
