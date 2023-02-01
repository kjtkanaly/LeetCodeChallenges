class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:

        k = 1
        while (True):
            hourCount = 0

            for pile in piles:

                hourCount += math.ceil(pile / k)
                
            if hourCount <= h:
                return k

            k += 1
