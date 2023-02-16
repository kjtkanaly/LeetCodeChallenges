class Solution:
    def myPow(self, x: float, n: int) -> float:

        if x == 1:
            return x
        elif x == -1:
            if n % 2 == 0:
                return -x
            else:
                return x

        val = 1

        for i in range(abs(n)):
            if n >= 0:
                val = val * x
            else:
                val = val / x
            if abs(val) < 0.000001:
                    return val

        return val