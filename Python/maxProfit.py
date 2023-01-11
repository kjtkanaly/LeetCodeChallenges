class Solution:
    def maxProfit(self, prices: List[int]) -> int:

        maxDiff = 0
        left = 0
        
        for right in range(1, len(prices)):
            if prices[right] < prices[left]:
                left = right
            
            maxDiff = max(maxDiff, prices[right] - prices[left])

        return maxDiff
